
using System;
using System.Text;

namespace cloudscribe.HtmlAgilityPack
{
    internal class EncodingFoundException : Exception
    {
        #region Fields

        private Encoding _encoding;

        #endregion

        #region Constructors

        internal EncodingFoundException(Encoding encoding)
        {
            _encoding = encoding;
        }

        #endregion

        #region Properties

        internal Encoding Encoding
        {
            get { return _encoding; }
        }

        #endregion
    }
}