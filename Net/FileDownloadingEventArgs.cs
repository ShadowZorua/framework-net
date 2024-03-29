﻿// This file is part of Mystery Dungeon eXtended.

// Mystery Dungeon eXtended is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Mystery Dungeon eXtended is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Mystery Dungeon eXtended.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace PMU.Net
{
    public class FileDownloadingEventArgs : EventArgs
    {
        long fileSize;
        string fileName;
        int percent;
        long position;
        string filePath;

        public FileDownloadingEventArgs(long fileSize, string filePath, int percent, long position) {
            this.fileSize = fileSize;
            this.filePath = filePath;
            this.fileName = System.IO.Path.GetFileName(filePath).Replace(".tmp", "");
            this.percent = percent;
            this.position = position;
        }

        public long FileSize {
            get { return fileSize; }
        }

        public string FileName {
            get { return fileName; }
        }

        public string FilePath {
            get { return filePath; }
        }

        public int Percent {
            get { return percent; }
        }

        public long Position {
            get { return position; }
        }

    }
}
