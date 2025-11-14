using BaseBackend.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Interface;

public interface iBaseService<T>
{
	void Add(T item);
	List<T> GetAll();

}
