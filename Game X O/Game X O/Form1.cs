namespace Game_X_O
{
    public partial class Form1 : Form
    {
        private int s=0;
        private int player;
        public Form1()
        {

            InitializeComponent();
            player = 1;
            label1.Text = "ױמה: ֳנאגוצü 1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x;
            
            if (sender.GetType().GetProperty("Text").GetValue(sender).ToString() == "")
            {
                
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "X");
                        player = 0;
                        label1.Text = "ױמה: ֳנאגוצü 2";
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "O");
                        player = 1;
                        label1.Text = "ױמה: ֳנאגוצü 1";
                        break;
                }
            }
                checkWin();
            
            if(checkBox1.Checked)
            { 
                
            if(player ==0&&s<5)
            {
                 m1:x = rnd.Next(1,9);
                switch (x)
                {
                    case 1:if (button1.Text == ""&&button1.Text!="X")
                            {
                                button1.Text = "O";
                                player = 1;
                                label1.Text = "ױמה: ֳנאגוצü 1";
                            }
                            else
                            {   
                                goto m1;
                            }
                        break;
                    case 2:
                        if (button2.Text == "" && button2.Text != "X")
                        {
                            button2.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 3:
                        if (button3.Text == "" && button3.Text != "X")
                        {
                            button3.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 4:
                        if (button4.Text == "" && button4.Text != "X")
                        {
                            button4.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 5:
                        if (button5.Text == "" && button5.Text != "X")
                        {
                            button5.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 6:
                        if (button6.Text == "" && button6.Text != "X")
                        {
                            button6.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 7:
                        if (button7.Text == "" && button7.Text != "X")
                        {
                            button7.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 8:
                        if (button8.Text == "" && button8.Text != "X")
                        {
                            button8.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                        break;
                    case 9:
                        if (button9.Text == "" && button9.Text != "X")
                        {
                            button9.Text = "O";
                            player = 1;
                            label1.Text = "ױמה: ֳנאגוצü 1";
                        }
                        else goto m1;
                            break;
                }
                  
            }
                checkWin();
            }
            s++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "ױמה: ֳנאגוצü 1";
            player = 1;
            s = 0;
        }
        private void checkWin()
        {
            bool w=false;
            if (button1.Text == button2.Text && button2.Text == button3.Text&& button1.Text != "")
            {
                w = true;  
                    
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text&& button4.Text != "")
            {
                w = true;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text&& button7.Text != "")
            {
                w = true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text&& button1.Text != "")
            {
                w = true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text&& button2.Text != "")
            {
                w = true;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text&& button3.Text != "")
            {

                w = true;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text&& button1.Text != "")
            {

                w = true;
            }
            if (button7.Text == button5.Text && button5.Text == button3.Text&& button3.Text != "")
            {
                w = true;
            }
            if (w)
            {
                if (player == 1)
                    MessageBox.Show("ֲטדנאג 2 דנאגוצü");
                if (player == 0)
                    MessageBox.Show("ֲטדנאג 1 דנאגוצü");
                clear();
            }
            else if(!w)
            {
                if(button1.Text!=""&&button2.Text!="" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                    MessageBox.Show("ֽ³קטÿ");
                    clear();
                }
            }
            }
    }
}