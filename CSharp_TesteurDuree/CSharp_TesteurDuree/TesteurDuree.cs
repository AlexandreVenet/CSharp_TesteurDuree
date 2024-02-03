using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TesteurDuree
{
	internal class TesteurDuree
	{
		private Stopwatch _watch;
		private TimeSpan _timeSpan;

		public void Demarrer()
		{
			_watch = Stopwatch.StartNew();
		}

		public void Arreter()
		{
			_watch.Stop();
		}

		public string ObtenirInfoDuree()
		{
			_timeSpan = ObtenirDuree();
			string duree = ObtenirDureeString();
			return "Durée approximative (hh:mm:ss.mmm) : " + duree;
		}

		public TimeSpan ObtenirDuree()
		{
			return _watch.Elapsed;
		}

		public string ObtenirDureeString()
		{
			return String.Format("{0:00}:{1:00}:{2:00}.{3:000}", _timeSpan.Hours, _timeSpan.Minutes, _timeSpan.Seconds, _timeSpan.Milliseconds);
		}

		public string ObtenirTamponHoraireString(string format = "dd-MM-yyyy hh:mm:ss.fff")
		{
			return DateTime.Now.ToString(format);
		}
	}
}
