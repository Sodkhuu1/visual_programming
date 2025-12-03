namespace biy_daalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double a = (double)Ainp.Value;
            double b = (double)Binp.Value;
            double c = (double)Cinp.Value;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        MessageBox.Show("Тэгшитгэл хязгааргүй олон шийдтэй.");
                    else
                        MessageBox.Show("Тэгшитгэл бодит шийдгүй.");
                }
                else
                {
                    double x = -c / b;
                    MessageBox.Show($"Шугаман тэгшитгэлийн шийд: x = {x}");
                }

                return;
            }

            double d = b * b - 4 * a * c;   

            if (d < 0)
            {
                MessageBox.Show("Бодит шийд байхгүй (D < 0).");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show($"Давхцсан нэг шийдтэй: x = {x}");
            }
            else
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                MessageBox.Show($"Хоёр бодит шийдтэй:\nx1 = {x1}\nx2 = {x2}");
            }
        }
    }
}
