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
    /// <summary>
    /// Provides an abstraction of common operations on a file, to facilitate mocking and unit testing.
    /// </summary>
    public class File : IFile, IDisposable
    {
        /// <summary>Indicates whether the object has been disposed.</summary>
        protected bool disposed;
        private string path;
        private System.IO.FileStream fileStream;

        /// <summary>
        /// Initialises a new instance of the StandardAbstraction.File class.
        /// </summary>
        public File()
        {
        }

        // TODO : Below constructor and 'Path' property are potentially legacy code (private 'path' member doesn't seem to be used anywhere in the class)
        //   Could potentially remove this constructor and property

        /// <summary>
        /// Initialises a new instance of the StandardAbstraction.File class.
        /// </summary>
        /// <param name="path">The full path to the file.</param>
        public File(string path)
        {
            this.path = path;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="P:StandardAbstraction.IFile.Path"]/*'/>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IFile.ReadAll"]/*'/>
        public string ReadAll()
        {
            string returnString;

            using (fileStream)
            {
                Open(System.IO.FileMode.Open);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    returnString = reader.ReadToEnd();
                }
                Close();
            }

            return returnString;
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IFile.WriteAll(System.String)"]/*'/>
        public void WriteAll(string data)
        {
            using (fileStream)
            {
                Open(System.IO.FileMode.Create);
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileStream))
                {
                    writer.Write(data);
                }
                Close();
            }
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IFile.ReadAllLines(System.String)"]/*'/>
        public string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        /// <include file='InterfaceDocumentationComments.xml' path='doc/members/member[@name="M:StandardAbstraction.IFile.OpenRead(System.String)"]/*'/>
        public IFileStream OpenRead(String path)
        {
            return new FileStream(System.IO.File.OpenRead(path));
        }

        /// <summary>
        /// Opens the file in exclusive mode so that other processes cannot access it.
        /// </summary>
        /// <param name="fileMode">The mode that the file should be opened in.</param>
        private void Open(System.IO.FileMode fileMode)
        {
            try
            {
                fileStream = System.IO.File.Open(path, fileMode, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
            }
            catch (Exception e)
            {
                throw new Exception("Failed to open file.", e);
            }
        }

        /// <summary>
        /// Closes the file.
        /// </summary>
        private void Close()
        {
            try
            {
                fileStream.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to close file.", e);
            }
        }

        #region Finalize / Dispose Methods

        /// <summary>
        /// Releases the unmanaged resources used by the File.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #pragma warning disable 1591
        ~File()
        {
            Dispose(false);
        }
        #pragma warning restore 1591

        /// <summary>
        /// Provides a method to free unmanaged resources used by this class.
        /// </summary>
        /// <param name="disposing">Whether the method is being called as part of an explicit Dispose routine, and hence whether managed resources should also be freed.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                    if (fileStream != null)
                    {
                        fileStream.Dispose();
                    }
                }
                // Free your own state (unmanaged objects).

                // Set large fields to null.
                path = null;
                disposed = true;
            }
        }

        #endregion
    }
}
