using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.classes;

public abstract class BaseEntity
{
	public BaseEntity()
	{

		date= DateTime.Now;


	}
	
	public int Id { get; set; }
	public DateTime date {  get; set; }	

}
