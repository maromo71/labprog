using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pessoa
/// </summary>
public class Pessoa
{
    public string Nome { get; set; }

    public DateTime DataNasc { get; set; }
    public Pessoa()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int CalcularIdade()
    {
        int anos = DateTime.Now.Year - this.DataNasc.Year;
        if (DateTime.Now.Month < this.DataNasc.Month || 
            (DateTime.Now.Month == this.DataNasc.Month) 
            && (DateTime.Now.Day < this.DataNasc.Day))
        {
            anos--;
        }
        return anos;
    }

}