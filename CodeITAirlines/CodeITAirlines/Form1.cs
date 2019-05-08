using System;
using System.Windows.Forms;
using System.Linq;
using CodeITAirlines.Models;
using System.Drawing;
using CodeITAirlines.Tools;
using CodeITAirlines.Enum;
using CodeITAirlines.Business;

namespace CodeITAirlines
{
    public partial class CodeITAirlines : Form
    {
        ViagemSmartFortwo ViagemSmartFortwo = new ViagemSmartFortwo();
        ViagemSmartFortwo ViagemSmartFortwoVolta = new ViagemSmartFortwo();
        CodeITAirlinesBusiness CodeITAirlinesBusiness = new CodeITAirlinesBusiness();

        TipoPessoa tipoPessoa;
        TipoPessoa tipoPessoaVolta;

        public CodeITAirlines()
        {
            InitializeComponent();
        }

        #region Eventos da Tela

        private void CodeITAirlines_Load(object sender, EventArgs e)
        {
            AtualizaGrids();
            VerificaoOndeEstaCarroEhabilitaCampos();

            HabilitaSelecionarPassageiroPiloto(false);
            HabilitaSelecionarPassageiroPilotoVolta(false);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (ViagemSmartFortwoVolta.Piloto == null)
            {
                MessageBox.Show("Necessário definir piloto!");
                return;
            }

            //chamar business
            var retornoMensagem = CodeITAirlinesBusiness.ValidarViagemVolta(ViagemSmartFortwoVolta);

            if (!string.IsNullOrEmpty(retornoMensagem))
            {
                MessageBox.Show(retornoMensagem);
                foreach (var row in dataGridAviao.Rows.Cast<DataGridViewRow>())
                {
                    row.Cells["colColorAviao"].Style.BackColor = Color.White;
                }
                return;
            }
            CodeITAirlinesBusiness.RealizaViagemParaTerminal(ViagemSmartFortwoVolta);

            ViagemSmartFortwoVolta = new ViagemSmartFortwo();
            AtualizaGrids();
            VerificaoOndeEstaCarroEhabilitaCampos();
        }
        private void btnEmbarcar_Click(object sender, EventArgs e)
        {
            if (ViagemSmartFortwo.Piloto == null)
            {
                MessageBox.Show("Necessário definir piloto!");
                return;
            }
            
            var retornoMensagem = CodeITAirlinesBusiness.ValidarViagemIda(ViagemSmartFortwo);

            if (!string.IsNullOrEmpty(retornoMensagem))
            {
                MessageBox.Show(retornoMensagem);
                foreach (var row in dataGridTerminal.Rows.Cast<DataGridViewRow>())
                {
                    row.Cells["colColor"].Style.BackColor = Color.White;
                }
                return;
            }
            CodeITAirlinesBusiness.RealizaViagemParaAviao(ViagemSmartFortwo);

            ViagemSmartFortwo = new ViagemSmartFortwo();
            AtualizaGrids();
            VerificaoOndeEstaCarroEhabilitaCampos();
        }


        private void btnDefinirPiloto_Click(object sender, EventArgs e)
        {
            var rows = from hasValue in dataGridTerminal.Rows.Cast<DataGridViewRow>()
                       where hasValue.Cells["colColor"].Style.BackColor == Color.BlueViolet
                       select hasValue;

            rows.ToList().ForEach(x => x.Cells["colColor"].Style.BackColor = Color.White);

            tipoPessoa = TipoPessoa.Piloto;
            HabilitaSelecionarPassageiroPiloto(true);
        }
        private void btnDefinePassageiro_Click(object sender, EventArgs e)
        {
            var rows = from hasValue in dataGridTerminal.Rows.Cast<DataGridViewRow>()
                       where hasValue.Cells["colColor"].Style.BackColor == Color.Blue
                       select hasValue;

            rows.ToList().ForEach(x => x.Cells["colColor"].Style.BackColor = Color.White);

            tipoPessoa = TipoPessoa.Passageiro;
            HabilitaSelecionarPassageiroPiloto(true);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridTerminal.SelectedRows.Count <= 0)
                return;

            if (dataGridTerminal.SelectedRows[0].Cells["colColor"].Style.BackColor == Color.BlueViolet)
            {
                MessageBox.Show("Esta pessoa foi definida como piloto!");
                return;
            }

            if (dataGridTerminal.SelectedRows[0].Cells["colColor"].Style.BackColor == Color.Blue)
            {
                MessageBox.Show("Esta pessoa foi definida como passageiro!");
                return;
            }

            var pessoaId = (int)dataGridTerminal.SelectedRows[0].Cells["colPessoaFisicaId"].Value;

            switch (tipoPessoa)
            {
                case TipoPessoa.Passageiro:

                    var passageiro = CodeITAirlinesBusiness.ConsultarPessoa(pessoaId);

                    var retorno = CodeITAirlinesBusiness.ValidarEmbarqueSmartFortwo(ViagemSmartFortwo.Piloto, passageiro);

                    if (!string.IsNullOrEmpty(retorno))
                    {
                        MessageBox.Show(retorno);
                        return;
                    }

                    ViagemSmartFortwo.Passageiro = passageiro;
                    dataGridTerminal.SelectedRows[0].Cells["colColor"].Style.BackColor = Color.Blue;
                    dataGridTerminal.ClearSelection();

                    HabilitaSelecionarPassageiroPiloto(false);

                    break;
                case TipoPessoa.Piloto:

                    if (!CodeITAirlinesBusiness.ValidarPermissaoPilotoSmartFortwo(pessoaId))
                    {
                        MessageBox.Show("Esta pessoa não permissão para pilotar!");
                        return;
                    }

                    var piloto = CodeITAirlinesBusiness.ConsultarPessoa(pessoaId);

                    if (ViagemSmartFortwo.Passageiro != null)
                    {
                        var retornoPassageiro = CodeITAirlinesBusiness.ValidarEmbarqueSmartFortwo(piloto, ViagemSmartFortwo.Passageiro);

                        if (!string.IsNullOrEmpty(retornoPassageiro))
                        {
                            MessageBox.Show(retornoPassageiro);
                            return;
                        }
                    }

                    ViagemSmartFortwo.Piloto = piloto;
                    dataGridTerminal.SelectedRows[0].Cells["colColor"].Style.BackColor = Color.BlueViolet;
                    dataGridTerminal.ClearSelection();

                    HabilitaSelecionarPassageiroPiloto(false);

                    break;
                default:
                    break;
            }
        }
        
        private void btnDefinePilotoVolta_Click(object sender, EventArgs e)
        {
            var rows = from hasValue in dataGridAviao.Rows.Cast<DataGridViewRow>()
                       where hasValue.Cells["colColorAviao"].Style.BackColor == Color.BlueViolet
                       select hasValue;

            rows.ToList().ForEach(x => x.Cells["colColorAviao"].Style.BackColor = Color.White);

            tipoPessoaVolta = TipoPessoa.Piloto;
            HabilitaSelecionarPassageiroPilotoVolta(true);

        }
        private void btnDefinePassageiroVolta_Click(object sender, EventArgs e)
        {
            var rows = from hasValue in dataGridAviao.Rows.Cast<DataGridViewRow>()
                       where hasValue.Cells["colColorAviao"].Style.BackColor == Color.Blue
                       select hasValue;

            rows.ToList().ForEach(x => x.Cells["colColorAviao"].Style.BackColor = Color.White);

            tipoPessoaVolta = TipoPessoa.Passageiro;
            HabilitaSelecionarPassageiroPilotoVolta(true);
        }
        private void btnConfirmaVolta_Click(object sender, EventArgs e)
        {
            if (dataGridAviao.SelectedRows.Count <= 0)
                return;

            if (dataGridAviao.SelectedRows[0].Cells["colColorAviao"].Style.BackColor == Color.BlueViolet)
            {
                MessageBox.Show("Esta pessoa foi definida como piloto!");
                return;
            }

            if (dataGridAviao.SelectedRows[0].Cells["colColorAviao"].Style.BackColor == Color.Blue)
            {
                MessageBox.Show("Esta pessoa foi definida como passageiro!");
                return;
            }

            var pessoaId = (int)dataGridAviao.SelectedRows[0].Cells["colPessoaFisicaIdAviao"].Value;
            switch (tipoPessoaVolta)
            {
                case TipoPessoa.Passageiro:
                    var passageiro = CodeITAirlinesBusiness.ConsultarPessoa(pessoaId);

                    var retorno = CodeITAirlinesBusiness.ValidarEmbarqueSmartFortwo(ViagemSmartFortwoVolta.Piloto, passageiro);

                    if (!string.IsNullOrEmpty(retorno))
                    {
                        MessageBox.Show(retorno);
                        return;
                    }

                    ViagemSmartFortwoVolta.Passageiro = passageiro;
                    dataGridAviao.SelectedRows[0].Cells["colColorAviao"].Style.BackColor = Color.Blue;
                    dataGridAviao.ClearSelection();

                    HabilitaSelecionarPassageiroPilotoVolta(false);
                    break;
                case TipoPessoa.Piloto:
                    if (!CodeITAirlinesBusiness.ValidarPermissaoPilotoSmartFortwo(pessoaId))
                    {
                        MessageBox.Show("Esta pessoa não permissão para pilotar!");
                        return;
                    }

                    var piloto = CodeITAirlinesBusiness.ConsultarPessoa(pessoaId);

                    if (ViagemSmartFortwoVolta.Passageiro != null)
                    {
                        var retornoPassageiro = CodeITAirlinesBusiness.ValidarEmbarqueSmartFortwo(piloto, ViagemSmartFortwoVolta.Passageiro);

                        if (!string.IsNullOrEmpty(retornoPassageiro))
                        {
                            MessageBox.Show(retornoPassageiro);
                            return;
                        }
                    }

                    ViagemSmartFortwoVolta.Piloto = piloto;
                    dataGridAviao.SelectedRows[0].Cells["colColorAviao"].Style.BackColor = Color.BlueViolet;
                    dataGridAviao.ClearSelection();

                    HabilitaSelecionarPassageiroPilotoVolta(false);
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridTerminal.ClearSelection();
            HabilitaSelecionarPassageiroPiloto(false);

            if (tipoPessoa == TipoPessoa.Passageiro)
                ViagemSmartFortwo.Passageiro = new PessoaFisica();
            else
                ViagemSmartFortwo.Piloto = new PessoaFisica();

        }
        private void btnCancelarVolta_Click(object sender, EventArgs e)
        {
            dataGridAviao.ClearSelection();
            HabilitaSelecionarPassageiroPilotoVolta(false);

            if (tipoPessoaVolta == TipoPessoa.Passageiro)
                ViagemSmartFortwoVolta.Passageiro = new PessoaFisica();
            else
                ViagemSmartFortwoVolta.Piloto = new PessoaFisica();
        }

        #endregion


        private void VerificaoOndeEstaCarroEhabilitaCampos()
        {
            var ultimaViagem = CodeITAirlinesBusiness.ConsultaUltimaViagem();

            var listaPessoas = CodeITAirlinesBusiness.ConsultarPessoas();
            
            
            grpAviao.Enabled = ultimaViagem.DestinoAviao == 1;
            grpTerminal.Enabled = ultimaViagem.DestinoTerminal == 1;

            if (grpAviao.Enabled && !listaPessoas.Any(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Embarcado))
            {
                grpAviao.Enabled = false;
                grpTerminal.Enabled = true;
            }

            if (grpTerminal.Enabled && !listaPessoas.Any(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Aguardando))
            {
                grpAviao.Enabled = true;
                grpTerminal.Enabled = false;
            }

        }
        private void HabilitaSelecionarPassageiroPiloto(bool habilita)
        {
            btnCancelar.Enabled = habilita;
            btnConfirmar.Enabled = habilita;
            dataGridTerminal.Enabled = habilita;
            btnDefinePassageiro.Enabled = !habilita;
            btnDefinePiloto.Enabled = !habilita;
        }
        private void HabilitaSelecionarPassageiroPilotoVolta(bool habilita)
        {
            btnCancelarVolta.Enabled = habilita;
            btnConfirmarVolta.Enabled = habilita;
            dataGridAviao.Enabled = habilita;
            btnDefinePassageiroVolta.Enabled = !habilita;
            btnDefinePilotoVolta.Enabled = !habilita;
        }
        private void AtualizaGrids()
        {
            var listPessoas = CodeITAirlinesBusiness.ConsultarPessoas();

            dataGridTerminal.DataSource = listPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Aguardando).ToList();
            dataGridTerminal.ClearSelection();
            
            dataGridAviao.DataSource = listPessoas.Where(x => x.SituacaoEmbarque == (int)SituacaoEmbarque.Embarcado).ToList();
            dataGridAviao.ClearSelection();
        }

        
    }
}
