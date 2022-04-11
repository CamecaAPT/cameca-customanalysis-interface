using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IAptFileInfo
{
    uint HeaderSize { get; }
    uint HeaderVersion { get; }
    string OriginalFilename { get; }
    string CurrentFilename { get; }
    DateTime CreationTime { get; }
    ulong IonCount { get; }
    Dictionary<string, IAptSectionInfo> SectionInfo { get; }
}