using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        bool SoundOn = true;

          MediaPlayer lala = new MediaPlayer();
          MediaPlayer lala1 = new MediaPlayer();
          MediaPlayer lala2 = new MediaPlayer();
          MediaPlayer lala3 = new MediaPlayer();
          MediaPlayer lala4 = new MediaPlayer();
          MediaPlayer lala5 = new MediaPlayer();
          MediaPlayer lala6 = new MediaPlayer();
          MediaPlayer lala7 = new MediaPlayer();
          MediaPlayer lala8 = new MediaPlayer();
          MediaPlayer SoundWhat = new MediaPlayer();
          MediaPlayer SoundOk = new MediaPlayer();

      
    


        private void Window_KeyDown(object sender, KeyEventArgs e)
         {
            if (SoundOn)
            {
                if (e.Key.ToString() == "Q")
             {
                 lala.Open(new Uri(@"Music\MusicBlock_1.wav", System.UriKind.Relative));
                 lala.Play();
                 button4.Background = button14.Background;
             }
                
             if (e.Key.ToString() == "W")
             {
                 lala1.Open(new Uri(@"Music\MusicBlock_2.wav", System.UriKind.Relative));
                 lala1.Play();
                 button2.Background = button14.Background;
             }
             if (e.Key.ToString() == "E")
             {
                 lala2.Open(new Uri(@"Music\MusicBlock_3.wav", System.UriKind.Relative));
                 lala2.Play();
                 button3.Background = button14.Background;
             }
             if (e.Key.ToString() == "A")
             {
                 lala3.Open(new Uri(@"Music\MusicBlock_4.wav", System.UriKind.Relative));
                 lala3.Play();
                 button11.Background = button14.Background;
             }
             if (e.Key.ToString() == "S")
             {
                 lala4.Open(new Uri(@"Music\MusicBlock_5.wav", System.UriKind.Relative));
                 lala4.Play();
                 button1.Background = button14.Background;
             }
             if (e.Key.ToString() == "D")
             {
                 lala5.Open(new Uri(@"Music\MusicBlock_6.wav", System.UriKind.Relative));
                 lala5.Play();
                 button5.Background = button14.Background;
             }
             if (e.Key.ToString() == "Z")
             {
                 lala6.Open(new Uri(@"Music\MusicBlock_7.wav", System.UriKind.Relative));
                 lala6.Play();
                 button6.Background = button14.Background;
             }
             if (e.Key.ToString() == "X")
             {
                 lala7.Open(new Uri(@"Music\MusicBlock_8.wav", System.UriKind.Relative));
                 lala7.Play();
                 button7.Background = button14.Background;
             }
             if (e.Key.ToString() == "C")
             {
                 lala8.Open(new Uri(@"Music\MusicBlock_9.wav", System.UriKind.Relative));
                 lala8.Play();
                 button8.Background = button14.Background;
             }

            }
          }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Q")
            {
                button4.Background = button15.Background;      
            }
            if (e.Key.ToString() == "W")
            {
                button2.Background = button15.Background;
            }
            if (e.Key.ToString() == "E")
            {
                button3.Background = button15.Background;
            }
            if (e.Key.ToString() == "A")
            {
                button11.Background = button15.Background;
            }
            if (e.Key.ToString() == "S")
            {
                button1.Background = button15.Background;
            }
            if (e.Key.ToString() == "D")
            {
                button5.Background = button15.Background;  
            }
            if (e.Key.ToString() == "Z")
            {
                button6.Background = button15.Background;
            }
            if (e.Key.ToString() == "X")
            {
                button7.Background = button15.Background;
            }
            if (e.Key.ToString() == "C")
            {
                button8.Background = button15.Background;
            }
        }
  
        private void checkBox1_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true) SoundOn = true;
            else SoundOn = false;    
  
        }

      // Rules
       private void button9_Click_1(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                SoundWhat.Open(new Uri(@"Music\MusicBlock_10.wav", System.UriKind.Relative));
                SoundWhat.Play();
            }

            // Function Rules
            MessageBox.Show(" Tab buttons : Q, W, E, A, S, D, Z, X, C \n Q - First Block \n W - Second Block \n E - Third block \n A - Fourth Block \n S - Fifth Block \n D - Sixth Block \n Z - Seventh Block \n X - Eighth Block \n C - Nineth Block \n\n Good Luck!!!");
            if (SoundOn)
            {

                SoundOk.Open(new Uri(@"Music\MusicBlock_11.wav", System.UriKind.Relative));
                SoundOk.Play();
            }
        
        }  
      //Block 1  
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala1.Open(new Uri(@"Music\MusicBlock_2.wav", System.UriKind.Relative));
                lala1.Play();
            }

        }
      //Block 2
        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala.Open(new Uri(@"Music\MusicBlock_1.wav", System.UriKind.Relative));
                lala.Play();

            }
          
        }
      //Block 3
        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala2.Open(new Uri(@"Music\MusicBlock_3.wav", System.UriKind.Relative));
                lala2.Play();
            }
            
        }
      //Block 4
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala3.Open(new Uri(@"Music\MusicBlock_4.wav", System.UriKind.Relative));
                lala3.Play();
            } 
        }
      //Block 5
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala4.Open(new Uri(@"Music\MusicBlock_5.wav", System.UriKind.Relative));
                lala4.Play();
            }  
        }
      //Block 6
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala5.Open(new Uri(@"Music\MusicBlock_6.wav", System.UriKind.Relative));
                lala5.Play();
            }  
        }
      //Block 7
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala6.Open(new Uri(@"Music\MusicBlock_7.wav", System.UriKind.Relative));
                lala6.Play();
            }  
        }
      //Block 8
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala7.Open(new Uri(@"Music\MusicBlock_8.wav", System.UriKind.Relative));
                lala7.Play();
            }  
        }
      //Block 9
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (SoundOn)
            {
                lala8.Open(new Uri(@"Music\MusicBlock_9.wav", System.UriKind.Relative));
                lala8.Play();
            }  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
       
        }
       

    }
     
         
   }

