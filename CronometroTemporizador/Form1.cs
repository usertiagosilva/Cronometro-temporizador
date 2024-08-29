namespace CronometroTemporizador
{
    public partial class Form1 : Form
    {
        private int segundosCronometro = 0;
        private int segundosTemporizador = 0;
        private int tempoDefinido = 0;
        

        public Form1()
        {
            InitializeComponent();

            // Configuração do Timer
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += timer1_Tick; // Associar o evento Tick
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuração adicional, se necessário
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualizar cronômetro
            segundosCronometro++;
            int minutosCronometro = segundosCronometro / 60;
            int segundosCronometroRestantes = segundosCronometro % 60;
            lblCronometro.Text = $"{minutosCronometro:D2}:{segundosCronometroRestantes:D2}";

            // Atualizar temporizador
            if (segundosTemporizador > 0)
            {
                segundosTemporizador--;
                AtualizarLabelTemporizador();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("O tempo acabou!");
            }
        }

        private void AtualizarLabelTemporizador()
        {
            int minutos = segundosTemporizador / 60;
            int segundos = segundosTemporizador % 60;
            lblTemporizador.Text = $"{minutos:D2}:{segundos:D2}";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            // Zera o cronômetro
            segundosCronometro = 0;
            segundosTemporizador = 0; // Se você também quiser zerar o temporizador

            // Atualiza o Label do cronômetro para mostrar "00:00"
            lblCronometro.Text = "00:00";
            lblTemporizador.Text = "00:00";
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTempoInicial.Text, out int minutosInicial))
            {
                tempoDefinido = minutosInicial * 60;
                segundosTemporizador = tempoDefinido;
                AtualizarLabelTemporizador();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido em minutos.");
            }
        }
    }
}