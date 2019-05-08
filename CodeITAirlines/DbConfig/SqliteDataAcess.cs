using CodeITAirlines.Enum;
using CodeITAirlines.Models;
using CodeITAirlines.Models.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace CodeITAirlines.DbConfig
{
    public static class SqliteDataAcess
    {
        private static string LoadConnection(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static ViagemSmartFortwo ConsultaUltimaViagem()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                var retorno = cnn.Query<ViagemSmartFortwo>(@"select * from ViagemSmartFortwo").OrderByDescending(x => x.DataRealizada).FirstOrDefault();
                return retorno;
            }
        }

        public static PessoaFisica ConsultarPessoa(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                var retorno = cnn.Query<PessoaFisica, Funcao, PessoaFisica>(@"
                                                        select 
                                                            P.*, F.*
                                                        from 
                                                            PessoaFisica P
                                                            left join Funcoes F on F.Id = P.FuncaoId", (pessoa, Funcao) => {
                                                                    pessoa.Funcao = Funcao; return pessoa; }).Where(x => x.Id == id);
                return retorno.FirstOrDefault();
            }
        }


        public static bool ValidarPermissaoPilotoSmartFortwo(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                return cnn.Query<PessoaFisica>(@"SELECT P.*
                                                FROM 
	                                                PessoaFisica P
	                                                LEFT JOIN Funcoes F on F.Id = P.FuncaoId
                                                WHERE
	                                                P.Id = @Id
	                                                AND EXISTS (select * from RegrasEmbarque where PilotoFuncaoId = F.Id)", 
                                                    new { Id = id }).Any();
            }
        }

        public static bool ValidarEmbarqueSmartFortwo(PessoaFisica Piloto, PessoaFisica Passageiro)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                return cnn.Query<PessoaFisica>(@"SELECT * from RegrasEmbarque 
                                                 WHERE PilotoFuncaoId = @pilotoFuncao 
                                                   AND (PassageiroFuncaoId = @passageiroFuncao or PassageiroSituacaoSocialId=@situacaoId)",
                                                    new { pilotoFuncao = Piloto.Funcao != null ? Piloto.Funcao.Id : (int?)null,
                                                          passageiroFuncao = Passageiro.Funcao != null ? Passageiro.Funcao.Id : (int?)null,
                                                          situacaoId = Passageiro.SituacaoSocialId.HasValue ? Passageiro.SituacaoSocialId.Value : (int?)null }).Any();
            }
        }

        public static string ValidarViagemIda(ViagemSmartFortwo ViagemSmartFortwo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                const int SITUACAO_SOCIAL_RECLUSAO = 2;
                const int HIERARQUIA_GRUPOTRIPULACAO = 1;

                var listaPessoas = ConsultarPessoasFisicas();
                var retornoTerminal = listaPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Aguardando);
                var retornoAviao = listaPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Embarcado);

                retornoTerminal = retornoTerminal.Where(x => x.Id != ViagemSmartFortwo.Piloto.Id);

                if (ViagemSmartFortwo.Passageiro != null)
                {
                    if (!retornoAviao.Any(x => x.Funcao.Hierarquia == HIERARQUIA_GRUPOTRIPULACAO) && ViagemSmartFortwo.Passageiro.SituacaoSocialId == SITUACAO_SOCIAL_RECLUSAO)
                        return "Para realizar esta viagem, é necessário que um dos líderes da Tripulação Técnica ou de Cabine esteja no Avião!";

                    retornoTerminal = retornoTerminal.Where(x => x.Id != ViagemSmartFortwo.Passageiro.Id);
                }

                if (retornoTerminal.Count() == 2)
                {
                    return ValidarPolitica(retornoTerminal.FirstOrDefault(), retornoTerminal.LastOrDefault());
                }
                return null;
            }
        }
        private static List<PessoaFisica> ConsultarPessoasFisicas()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                var retorno = cnn.Query<PessoaFisica, Funcao, PessoaFisica>(@"
                                                                    select 
	                                                                    P.*, F.*
                                                                    from 
	                                                                    PessoaFisica P
	                                                                    left join Funcoes F on F.Id = P.FuncaoId
	                                                                    INNER join Terminal T on T.PessoaFisicaId = P.Id", 
                                                                     (p, f) => { p.Funcao = f; return p; }).ToList();
                return retorno;
            }
        }

        public static string ValidarViagemVolta(ViagemSmartFortwo ViagemSmartFortwo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                const int SITUACAO_SOCIAL_RECLUSAO = 2;
                const int HIERARQUIA_GRUPTRIPULACAO = 1;

                var listaPessoas = ConsultarPessoasFisicas();
                var retornoTerminal = listaPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Aguardando);
                var retornoAviao = listaPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Embarcado);

                retornoAviao = retornoTerminal.Where(x => x.Id != ViagemSmartFortwo.Piloto.Id);

                if (ViagemSmartFortwo.Passageiro != null)
                {
                    if (!retornoAviao.Any(x => x.Funcao.Hierarquia == HIERARQUIA_GRUPTRIPULACAO) && ViagemSmartFortwo.Passageiro.SituacaoSocialId == SITUACAO_SOCIAL_RECLUSAO)
                        return "Para realizar esta viagem, é necessário que um dos líderes da Tripulação Técnica ou de Cabine esteja no Avião!";

                    retornoAviao = retornoAviao.Where(x => x.Id != ViagemSmartFortwo.Passageiro.Id);
                }
                
                if(retornoAviao.Count() == 2)
                {
                    return ValidarPolitica(retornoAviao.FirstOrDefault(), retornoAviao.LastOrDefault());
                }
                return null;   
            }
        }

        public static void RealizaViagemParaAviao(ViagemSmartFortwo ViagemSmartFortwo)
        {
            ViagemSmartFortwo.DataRealizada = DateTime.Now;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                cnn.Execute(@"INSERT INTO ViagemSmartFortwo 
                            (PilotoId, PassageiroId, DestinoAviao, DestinoTerminal, DataRealizada) values 
                            (@PilotoId, @PassageiroId, 1, 0,  @DataRealizada)", ViagemSmartFortwo );

                cnn.Execute("UPDATE PessoaFisica SET SituacaoEmbarque = 2 where  Id = @Id", ViagemSmartFortwo.Piloto);

                if (ViagemSmartFortwo.Passageiro != null)
                    cnn.Execute("UPDATE PessoaFisica SET SituacaoEmbarque = 2 where  Id = @Id", ViagemSmartFortwo.Passageiro);
                
            }
        }

        public static void RealizaViagemParaTerminal(ViagemSmartFortwo ViagemSmartFortwo)
        {
            ViagemSmartFortwo.DataRealizada = DateTime.Now;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                cnn.Execute(@"INSERT INTO ViagemSmartFortwo 
                            (PilotoId, PassageiroId, DestinoAviao, DestinoTerminal, DataRealizada) values 
                            (@PilotoId, @PassageiroId, 0, 1,  @DataRealizada)", ViagemSmartFortwo);

                cnn.Execute("UPDATE PessoaFisica SET SituacaoEmbarque = 1 where  Id = @Id", ViagemSmartFortwo.Piloto);

                if (ViagemSmartFortwo.Passageiro != null)
                    cnn.Execute("UPDATE PessoaFisica SET SituacaoEmbarque = 1 where  Id = @Id", ViagemSmartFortwo.Passageiro);
            }
        } 

        private static string ValidarPolitica(PessoaFisica pessoa, PessoaFisica pessoa2)
        {
            if (pessoa.Funcao.GrupoTripulacaoId != pessoa2.Funcao.GrupoTripulacaoId &&
                pessoa.Funcao.Hierarquia != pessoa2.Funcao.Hierarquia)
            {
                return String.Format(@".Faz parte da política da empresa que {0} e {1} não podem ficar sozinhos", pessoa.Funcao.Descricao, pessoa2.Funcao.Descricao);
            }
            return null;
        }


        public static List<PessoaDTO> ConsultarPessoas()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                string query = @"select
	                                P.Id as PessoaFisicaId,
                                    P.SituacaoEmbarque,
	                                P.Nome, 
	                                F.Descricao as Funcao,
	                                G.Descricao as GrupoTripulacao, 
	                                S.Descricao as SituacaoSocial
                                from 
	                                PessoaFisica P
	                                left join SituacaoSocial S on S.Id = P.SituacaoSocialId	
	                                left join Funcoes 		  F on F.Id = P.FuncaoId
	                                left join GrupoTripulacao G on G.Id = F.GrupoTripulacaoId";

                var retorno = cnn.Query<PessoaDTO>(query);

                return retorno.ToList();
            }
        }

        public static void Embarcar(ViagemSmartFortwo viagemSmartFortwo)
        {
            const int EMBARCADO = 1;
            var pilotoId = viagemSmartFortwo.Piloto.Id;
            var passageiroId = viagemSmartFortwo.Passageiro.Id;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnection()))
            {
                cnn.Execute(@"UPDATE Terminal SET 
                                     Embarcado = @EMBARCADO 
                              WHERE 
                                     PessoaFisicaId in (@PilotoId, 
                                                        @PassageiroId)", 
                            new { EMBARCADO, pilotoId, passageiroId });
                
            }
        }
    }
}
