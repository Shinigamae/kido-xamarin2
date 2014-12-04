using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.FSharp.Core;

using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using K = Kidozen;
using U = Utilities;
using A = Application;
using C = Crash;
using F = Files;

using Newtonsoft.Json;
using Newtonsoft;


public interface IDataVisualization {
	void LaunchView (string visualization, string targetdirectory); 
	string GetDestinationDirectory (string visualization); 
	string GetTargetDirectory (); 
	bool UnzipFiles (string path, string zipname);
}