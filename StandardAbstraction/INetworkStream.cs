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
    /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="T:StandardAbstraction.INetworkStream"]/*'/>
    public interface INetworkStream
    {
        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.INetworkStream.CanRead"]/*'/>
        bool CanRead
        {
            get;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.INetworkStream.Read(System.Byte[]@,System.Int32,System.Int32)"]/*'/>
        int Read(ref byte[] buffer, int offset, int size);

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.INetworkStream.ReadByte"]/*'/>
        int ReadByte();

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.INetworkStream.Write(System.Byte[],System.Int32,System.Int32)"]/*'/>
        void Write(byte[] buffer, int offset, int size);

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.INetworkStream.WriteByte(System.Byte)"]/*'/>
        void WriteByte(byte value);
    }
}
