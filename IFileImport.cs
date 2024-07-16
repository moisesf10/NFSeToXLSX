using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSeToXLSX
{
	public interface IFileImport
	{
		public (bool, string) loadFile (string filePath);
		public IDictionary<string, string> readFile(int index = 0);
		public IEnumerable<IDictionary<string, string>> readFiles();

	}
}
