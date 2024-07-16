using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Web.Controllers;

namespace Cod3rsGrowth.Forms
{
    public partial class FormNovoBaralho : Form
    {
        private Jogador jogador;
        private CartaServico cartaServico;
        private BaralhoServico baralhoServico;
        private JogadorServico jogadorServico;
        private JwtServico tokenServico;
        private ConexaoDados conexaoDados;
        private LoginController loginController;
        private Thread threadFormListaBaralhoJogador;

        public FormNovoBaralho(CartaServico _cartaServico, BaralhoServico _baralhoServico, JogadorServico _jogadorServico,
            JwtServico _tokenServico, ConexaoDados _conexaoDados, LoginController _loginController, Jogador _jogador)
        {
            jogador = _jogador;
            cartaServico = _cartaServico;
            baralhoServico = _baralhoServico;
            jogadorServico = _jogadorServico;
            tokenServico = _tokenServico;
            conexaoDados = _conexaoDados;
            loginController = _loginController;

            InitializeComponent();
        }
    }
}
