namespace Penguin.Files.Abstractions
{
    /// <summary>
    /// A simple interface for passing around a file
    /// </summary>
    public interface IFile
    {
        #region Properties

        /// <summary>
        /// A byte array representing the file contents
        /// </summary>
        byte[] Data { get; }

        /// <summary>
        /// The full path to the file, or full name for the file
        /// </summary>
        string FileName { get; }

        #endregion Properties
    }
}