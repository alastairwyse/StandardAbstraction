/*
 * Copyright 2023 Alastair Wyse (https://github.com/alastairwyse/StandardAbstraction)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace StandardAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:StandardAbstraction.IStopwatch"]/*'/>
    public class Stopwatch : IStopwatch
    {
        private System.Diagnostics.Stopwatch stopwatch;

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.Frequency"]/*'/>
        public Int64 Frequency 
        {
            get { return System.Diagnostics.Stopwatch.Frequency; }
        }

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
        public Int64 ElapsedMilliseconds
        {
            get { return stopwatch.ElapsedMilliseconds; }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.ElapsedTicks"]/*'/>
        public Int64 ElapsedTicks
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
