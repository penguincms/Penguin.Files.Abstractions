namespace Penguin.Files.Abstractions
{
    /// <summary>
    /// A simple interface for passing around a file
    /// </summary>
    public interface IFile
    {
        /// <summary>
        /// A byte array representing the file contents
        /// </summary>
        byte[] Data { get; set; }

        /// <summary>
        /// The full path to the file, or full name for the file
        /// </summary>
        string FullName { get; set; }
    }
}