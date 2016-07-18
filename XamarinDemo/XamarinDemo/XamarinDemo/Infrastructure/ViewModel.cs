using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDemo.Infrastructure
{
	public class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected void Set<T>(ref T field, T value, [CallerMemberName] string propertyValue = null)
		{
			//if (!field?.Equals(value) ?? false)
			//{
				field = value;
				OnPropertyChanged(propertyValue);
			//}
		}
	}
}
