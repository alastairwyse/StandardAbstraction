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
using System.Linq;
using System.Text;

namespace StandardAbstraction
{
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:StandardAbstraction.IFileInfo"]/*'/>
    public class FileInfo : IFileInfo
    {
        private System.IO.FileInfo fileInfo;

        /// <summary>
        /// Initialises a new instance of the StandardAbstraction.FileInfo class.
        /// </summary>
        public FileInfo(System.IO.FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IFileInfo.DirectoryName"]/*'/>
        public string DirectoryName
        {
            get
            {
                return fileInfo.DirectoryName;
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IFileInfo.Name"]/*'/>
        public string Name
        {
            get
            {
                return fileInfo.Name;
            }
        }
    }
}
