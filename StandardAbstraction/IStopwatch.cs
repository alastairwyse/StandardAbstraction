/*
 * Copyright 2021 Alastair Wyse (https://github.com/alastairwyse/StandardAbstraction)
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
    public interface IStopwatch
    {
        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.Elapsed"]/*'/>
        TimeSpan Elapsed { get; }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.ElapsedMilliseconds"]/*'/>
        Int64 ElapsedMilliseconds { get; }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IStopwatch.ElapsedTicks"]/*'/>
        Int64 ElapsedTicks { get; }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Start"]/*'/>
        void Start();

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Stop"]/*'/>
        void Stop();

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IStopwatch.Reset"]/*'/>
        void Reset();
    }
}
