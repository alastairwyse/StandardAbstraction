using System;
using System.Collections.Generic;
using System.Text;

namespace StandardAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:StandardAbstraction.IStopwatch"]/*'/>
    public class Stopwatch : IStopwatch
    {
        private System.Diagnostics.Stopwatch stopwatch;

        /// <summary>
        /// Initialises a new instance of the StandardAbstraction.Stopwatch class.
        /// </summary>
        public Stopwatch()
        {
            stopwatch = new System.Diagnostics.Stopwatch();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.Elapsed"]/*'/>
        public TimeSpan Elapsed
        {
            get { return stopwatch.Elapsed; }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.ElapsedMilliseconds"]/*'/>
        public long ElapsedMilliseconds
        {
            get { return stopwatch.ElapsedMilliseconds; }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.ElapsedTicks"]/*'/>
        public long ElapsedTicks
        {
            get { return stopwatch.ElapsedTicks; }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Start"]/*'/>
        public void Start()
        {
            stopwatch.Start();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Stop"]/*'/>
        public void Stop()
        {
            stopwatch.Stop();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Reset"]/*'/>
        public void Reset()
        {
            stopwatch.Reset();
        }
    }
}
