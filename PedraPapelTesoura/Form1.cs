namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    { 
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //imagem do computador
        Image[] imgCpu = new Image[]
        {
            Properties.Resources.PedraC,
            Properties.Resources.PapelC,
            Properties.Resources.TesouraC
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            picJogador.Image = btn.BackgroundImage;

            //converte a tag 0,1 ou 2 em imagem pro jogador 
            Jogada jogadaJogador = retornaJogadaJogador(Convert.ToInt32(btn.Tag));

            Jogada jogadaAdversario = retornaJogadaAdversario();

            //nesse metodo ira passar as jogadas, tanto do jogador quanto a do adversario 
            //pra comprarar quem ganhou
            Resultado resulta = retornaGanhador(jogadaJogador, jogadaAdversario);

            //validar o resultado de quem foi o vencedor
            if (resulta == Resultado.vitoriaCpu)
            {
                //vai atribuir a pontuação do adversario somar +1 e converter para string 
                lblPtCpu.Text = (int.Parse(lblPtCpu.Text) + 1).ToString();
                if (lblPtCpu.Text == "5")
                {
                
                   MessageBox.Show("que pena jogador você perdeu!","Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); 
                }
                else if (lblPtJogador.Text == "5")
                {
                    

                        MessageBox.Show("Parabéns jogaodr !", "Informação",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                    
                }
                
            }
            else if (resulta == Resultado.vitoriaJogador)
            {
                //vai atribuir a pontuação do jogador somar +1 e converter para string
                lblPtJogador.Text = (int.Parse(lblPtJogador.Text) + 1).ToString();
            }         
        }
               
        private Resultado retornaGanhador(Jogada jogador, Jogada adversario)
        { 
           
            //valida as jogadas dos jogadores
            if (jogador == Jogada.pedra)
            {
                if(adversario == Jogada.papel)
                {
                    return Resultado.vitoriaCpu;
                }
                else if(adversario == Jogada.tesoura)
                {
                    return Resultado.vitoriaJogador;
                }
            }
            else if(jogador == Jogada.papel)
            {

                if (adversario == Jogada.pedra)
                {
                    return Resultado.vitoriaJogador;
                }
                else if (adversario == Jogada.tesoura)
                {
                    return Resultado.vitoriaCpu;
                }
            }
            else
            {

                if (adversario == Jogada.pedra)
                {
                    return Resultado.vitoriaCpu;
                }
                else if (adversario == Jogada.papel)
                {
                    return Resultado.vitoriaJogador;
                }
            }
            return Resultado.empate;
        }

        private Jogada retornaJogadaJogador(int escolha)
        {
            //retorna a escolha do jogador
            return (Jogada)escolha;
        }
        private Jogada retornaJogadaAdversario()
        {
            //faz um sorteio de uma classe
            Random rnd = new Random();

            //armazena o sorteio dentro de um valor inteiro chamado escolha
            //o 3 significa q irá começar o sorteio com 3 numeros começando pelo zero
            int escolha = rnd.Next(3);
            picCpu.Image = imgCpu[escolha];
            //retorna a jogada do adversario
            return (Jogada)escolha;

        }
        
        enum Jogada
        {
            pedra = 0,
            papel = 1,
            tesoura = 2
        } 
        enum Resultado
        {
            vitoriaJogador,
            vitoriaCpu,
            empate
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblPtJogador.Text = "0";
            lblPtCpu.Text = "0";

        }
    }
}