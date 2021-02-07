using Quartz;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Survey
{
    public class AnketTemizleyici : IJob
    {
        AnketModel db = new AnketModel();
        Task IJob.Execute(IJobExecutionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            Task taskA = new Task(() => dbSil());

            taskA.Start();
            return taskA;
        }
        void dbSil()
        {
            List<Anketler> anketler = db.Anketler.Where(i => i.Anket_Bitis_Tarih < System.DateTime.Now).ToList();
            foreach (Anketler anket in anketler)
            {
                db.Secenekler.RemoveRange(db.Anketler.Where(i => i.Anket_ID == anket.Anket_ID).FirstOrDefault().Sorular.SelectMany(b => b.Secenekler));
                db.Yanitlar.RemoveRange(db.Anketler.Where(i => i.Anket_ID == i.Anket_ID).FirstOrDefault().Sorular.SelectMany(b => b.Yanitlar));
                db.Sorular.RemoveRange(db.Anketler.Where(i => i.Anket_ID == i.Anket_ID).FirstOrDefault().Sorular);
            }
            db.Anketler.RemoveRange(anketler);
            db.SaveChanges();
        }
    }
}