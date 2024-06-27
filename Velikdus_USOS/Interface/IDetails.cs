using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velikdus_USOS.Interface
{
    public interface IDetails
    {
        string Card { get; }
        string Topic { get; }
        string Sala { get; }
        string Advisor { get; }
        int WrittenArticles { get; }
        List<string> GetInfoDoktorant();
        /// <summary>
        /// 
        /// </summary>
        string Id { get; }
        int Course { get; }
        double Avarage { get; }
        string Major { get; }
        bool IsContract { get; }
        bool IsInternationalStudent {  get; }
        List<string> GetInfoStudent();
    }
}
