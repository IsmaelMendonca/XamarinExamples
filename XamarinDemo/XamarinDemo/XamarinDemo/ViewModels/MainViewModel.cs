using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDemo.Infrastructure;

namespace XamarinDemo.ViewModels
{
	public class MainViewModel : ViewModel
	{
		private string _name;
		private string _result;

		public MainViewModel()
		{
			LoginCommand = new Command(Login);
			ClearCommand = new Command(Clear);
		}

		public string Name
		{
			get { return _name; }
			set { Set(ref _name, value); }
		}

		public string Result
		{
			get { return _result; }
			set { Set(ref _result, value); }
		}

		public ICommand LoginCommand { get; set; }
		public ICommand ClearCommand { get; set; }

		public void Login()
		{
			Result = string.Format("Olá {0}", Name);
		}

		public void Clear()
		{
			Name = string.Empty;
			Result = string.Empty;
		}
	}
}
