namespace tictactoe
{
    public partial class Form1 : Form
    {
        public int spieler = 2;
        public int zug = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        public Form1()
        {
            InitializeComponent();
        }
       

        bool IsDraw()
        {
           if ((zug == 9) &&(IsWinner() == false))
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        bool IsWinner()
        {
            // Horizontal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "") 
                return true;
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "") 
                return true;
            if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "") 
                return true;

            // Vertikal

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "") 
                return true;
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "") 
                return true;
            if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "") 
                return true;

            // Diagonal
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "") 
                return true;
            if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "") 
                return true;
            else
            return false;
        }





        private void Bttn_ns_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        public void NeuesSpiel()
        {
            spieler = 2;
            zug = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

            lbl_x.Text = "x: " + s1;
            lbl_y.Text = "y: " + s2;
            lbl_draw.Text = "Draw: " + sd;
        }
        private void Bttn_reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NeuesSpiel();
        }

        private void Bttn_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_x.Text = "x: " + s1;
            lbl_y.Text = "y: " + s1;
            lbl_draw.Text = "Draw: " + s1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        
        }
        private void Label4_Click(object sender, EventArgs e)
        { }
        private void buttonsClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "")
            {
                if (spieler % 2 == 0)
                {
                    button.Text = "x";
                    spieler++;
                    zug++;

                }
                else
                {
                    button.Text = "0";
                    spieler++;
                    zug++;
                }
                if (IsDraw() == true)
                {
                    MessageBox.Show("Unentschieden");
                    sd++;
                    NeuesSpiel();
                }
                if (IsWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X hat gewonnen");
                        s1++;
                        NeuesSpiel();
                    }
                    else 
                    {
                        MessageBox.Show("Y hat gewonnen");
                        s2++;
                        NeuesSpiel();
                    }

                }
                
            }
        }

    }
}
