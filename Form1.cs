using Microsoft.VisualBasic.Logging;

namespace Practica_Hilos_23130020
{
    public partial class FrmHilo : Form
    {
        Thread p1, p2, p3, p4;
        byte r1, g1, b1;
        byte r2, g2, b2;
        byte r3, g3, b3;
        byte r4, g4, b4;
        bool b1Up, b2Up, b3Up, b4Up;
        int cycle1, cycle2, cycle3, cycle4;
        const int maxCycles = 3;
        bool working = false;

        public FrmHilo()
        {
            InitializeComponent();
        }

        private void FrmHilo_Load(object sender, EventArgs e)
        {
            // Inicializar los valores RGB y las banderas para el movimiento
            r1 = 0; g1 = 0; b1 = 0; b1Up = true; cycle1 = 0;
            r2 = 0; g2 = 0; b2 = 0; b2Up = true; cycle2 = 0;
            r3 = 0; g3 = 0; b3 = 0; b3Up = true; cycle3 = 0;
            r4 = 0; g4 = 0; b4 = 0; b4Up = true; cycle4 = 0;
        }

        private void Hilo1()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (!working) break;

                // Cambiar los valores RGB de 0 a 255 y luego de vuelta a 0
                if (b1Up)
                {
                    r1 = (byte)((r1 + 1) % 256);
                    g1 = (byte)((g1 + 0) % 256);
                    b1 = (byte)((b1 + 0) % 256);
                    if (r1 == 255 && g1 == 255 && b1 == 255) b1Up = false;
                }
                else
                {
                    r1 = (byte)((r1 - 1) % 256);
                    g1 = (byte)((g1 - 1) % 256);
                    b1 = (byte)((b1 - 1) % 256);
                    if (r1 == 0 && g1 == 0 && b1 == 0) b1Up = true;
                }

                pictureBox1.BackColor = Color.FromArgb(r1, g1, b1);

                if (r1 == 0 && g1 == 0 && b1 == 0)
                {
                    cycle1++;
                    if (cycle1 == maxCycles) cycle1 = 0; // Finaliza un ciclo, resetea el contador
                    if (cycle1 == 0) break; // Pausar después de completar 3 ciclos
                }
            }

            StartNextPictureBox(2); // Después de terminar PictureBox 1, inicia PictureBox 2
        }

        // Hilo para PictureBox 2
        private void Hilo2()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (!working) break;

                // Cambiar los valores RGB de 0 a 255 y luego de vuelta a 0
                if (b2Up)
                {
                    r2 = (byte)((r2 + 0) % 256);
                    g2 = (byte)((g2 + 1) % 256);
                    b2 = (byte)((b2 + 0) % 256);
                    if (r2 == 255 && g2 == 255 && b2 == 255) b2Up = false;
                }
                else
                {
                    r2 = (byte)((r2 - 0) % 256);
                    g2 = (byte)((g2 - 1) % 256);
                    b2 = (byte)((b2 - 0) % 256);
                    if (r2 == 0 && g2 == 0 && b2 == 0) b2Up = true;
                }

                pictureBox2.BackColor = Color.FromArgb(r2, g2, b2);

                if (r2 == 0 && g2 == 0 && b2 == 0)
                {
                    cycle2++;
                    if (cycle2 == maxCycles) cycle2 = 0; // Finaliza un ciclo, resetea el contador
                    if (cycle2 == 0) break; // Pausar después de completar 3 ciclos
                }
            }

            StartNextPictureBox(3); // Después de terminar PictureBox 2, inicia PictureBox 3
        }

        // Hilo para PictureBox 3
        private void Hilo3()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (!working) break;

                // Cambiar los valores RGB de 0 a 255 y luego de vuelta a 0
                if (b3Up)
                {
                    r3 = (byte)((r3 + 0) % 256);
                    g3 = (byte)((g3 + 0) % 256);
                    b3 = (byte)((b3 + 1) % 256);
                    if (r3 == 255 && g3 == 255 && b3 == 255) b3Up = false;
                }
                else
                {
                    r3 = (byte)((r3 - 0) % 256);
                    g3 = (byte)((g3 - 0) % 256);
                    b3 = (byte)((b3 - 1) % 256);
                    if (r3 == 0 && g3 == 0 && b3 == 0) b3Up = true;
                }

                pictureBox3.BackColor = Color.FromArgb(r3, g3, b3);

                if (r3 == 0 && g3 == 0 && b3 == 0)
                {
                    cycle3++;
                    if (cycle3 == maxCycles) cycle3 = 0; // Finaliza un ciclo, resetea el contador
                    if (cycle3 == 0) break; // Pausar después de completar 3 ciclos
                }
            }

            StartNextPictureBox(4); // Después de terminar PictureBox 3, inicia PictureBox 4
        }

        // Hilo para PictureBox 4
        private void Hilo4()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (!working) break;

                // Cambiar los valores RGB de 0 a 255 y luego de vuelta a 0
                if (b4Up)
                {
                    r4 = (byte)((r4 + 1) % 256);
                    g4 = (byte)((g4 + 0) % 256);
                    b4 = (byte)((b4 + 0) % 256);
                    if (r4 == 255 && g4 == 255 && b4 == 255) b4Up = false;
                }
                else
                {
                    r4 = (byte)((r4 - 1) % 256);
                    g4 = (byte)((g4 - 0) % 256);
                    b4 = (byte)((b4 - 0) % 256);
                    if (r4 == 0 && g4 == 0 && b4 == 0) b4Up = true;
                }

                pictureBox4.BackColor = Color.FromArgb(r4, g4, b4);

                if (r4 == 0 && g4 == 0 && b4 == 0)
                {
                    cycle4++;
                    if (cycle4 == maxCycles) cycle4 = 0; // Finaliza un ciclo, resetea el contador
                    if (cycle4 == 0) break; // Pausar después de completar 3 ciclos
                }
            }

            StartNextPictureBox(1); // Después de terminar PictureBox 4, reinicia con PictureBox 1
        }

        private void StartNextPictureBox(int nextPictureBox)
        {
            if (nextPictureBox == 2)
            {
                p2 = new Thread(new ThreadStart(Hilo2));
                p2.Start();
            }
            else if (nextPictureBox == 3)
            {
                p3 = new Thread(new ThreadStart(Hilo3));
                p3.Start();
            }
            else if (nextPictureBox == 4)
            {
                p4 = new Thread(new ThreadStart(Hilo4));
                p4.Start();
            }
            else if (nextPictureBox == 1)
            {
                p1 = new Thread(new ThreadStart(Hilo1));
                p1.Start();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            working = true;
            p1 = new Thread(new ThreadStart(Hilo1));
            p1.Start();
        }
        private void FrmHilo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
