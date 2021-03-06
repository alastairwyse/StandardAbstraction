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
using System.Collections.Generic;
using System.Text;

namespace StandardAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:StandardAbstraction.IConsole"]/*'/>
    public class Console : IConsole
    {
        /// <summary>
        /// Initialises a new instance of the StandardAbstraction.Console class.
        /// </summary>
        public Console()
        {
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IConsole.Write(System.String)"]/*'/>
        public void Write(string value)
        {
            System.Console.Write(value);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IConsole.WriteLine"]/*'/>
        public void WriteLine()
        {
            System.Console.WriteLine();
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IConsole.WriteLine(System.String)"]/*'/>
        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IConsole.Clear"]/*'/>
        public void Clear()
        {
            System.Console.Clear();
        }
    }
}
