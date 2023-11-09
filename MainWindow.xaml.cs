using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_gyakorlas
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

		private void plusButton_Click(object sender, RoutedEventArgs e)
		{
			if (tb1.Text==""|| tb2.Text=="")
			{
				MessageBox.Show("Minden mező kitöltése kötelező!");
			}
			else
			{
				try
				{
					eLabel.Content = (Convert.ToInt32(tb1.Text)) + (Convert.ToInt32(tb2.Text));
				}
				catch (Exception)
				{
					MessageBox.Show("Érvénytelen érték/ek!");
				}
			}
		}

		private void minusButton_Click(object sender, RoutedEventArgs e)
		{
			if (tb1.Text == "" || tb2.Text == "")
			{
				MessageBox.Show("Minden mező kitöltése kötelező!");
			}
			else
			{
				try
				{
					eLabel.Content = (Convert.ToInt32(tb1.Text)) - (Convert.ToInt32(tb2.Text));
				}
				catch (Exception)
				{
					MessageBox.Show("Érvénytelen érték/ek!");
				}
			}
		}

		private void timesButton_Click(object sender, RoutedEventArgs e)
		{
			if (tb1.Text == "" || tb2.Text == "")
			{
				MessageBox.Show("Minden mező kitöltése kötelező!");
			}
			else
			{
				try
				{
					eLabel.Content = (Convert.ToInt32(tb1.Text)) * (Convert.ToInt32(tb2.Text));
				}
				catch (Exception)
				{
					MessageBox.Show("Érvénytelen érték/ek!");
				}
			}
		}

		private void divideButton_Click(object sender, RoutedEventArgs e)
		{
			if (tb1.Text == "" || tb2.Text == "")
			{
				MessageBox.Show("Minden mező kitöltése kötelező!");
			}
			else
			{
				try
				{
					eLabel.Content = Math.Round((Convert.ToDouble(tb1.Text)) / (Convert.ToDouble(tb2.Text)),2);
				}
				catch (Exception)
				{
					MessageBox.Show("Érvénytelen érték/ek!");
				}
			}
		}

		private void divide2Button_Click(object sender, RoutedEventArgs e)
		{
			if (tb1.Text == "" || tb2.Text == "")
			{
				MessageBox.Show("Minden mező kitöltése kötelező!");
			}
			else
			{
				try
				{
					eLabel.Content = (Convert.ToInt32(tb1.Text)) % (Convert.ToInt32(tb2.Text));
				}
				catch (Exception)
				{
					MessageBox.Show("Érvénytelen érték/ek!");
				}
			}
		}
	}
}
