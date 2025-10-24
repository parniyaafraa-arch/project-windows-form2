using project_windows_form2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2.Interface
{
	public interface BaseService<T>
	{
		void Add(T item);
		List<T> GetAll();

	}
}
