using System;

public struct Result
{
    public long Size; //in bytes
    public DateTime DateModified;
    public string Filename;
    public string Path;

    public bool Folder => Size < 0;

    public override string ToString()
        => $"Name: {Filename}\tSize (B): {(Folder ? "(Folder)" : Size)}\tModified: {DateModified:d}\tPath: {Path.Substring(0, 10)}...";
}