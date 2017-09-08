using System;
using System.IO;

namespace Compiler
{
    public class CustomStream : IDisposable
    {
        private readonly StreamReader _stream;
        private int _lastChar;
        private bool _isBack;

        public bool EndOfStream => _stream.EndOfStream;

        public CustomStream(StreamReader stream)
        {
            _stream = stream;
        }

        public void Next()
        {
            if (_isBack)
            {
                _isBack = false;
                return;
            }

            _lastChar = _stream.Read();
        }

        public char Peek()
        {
            if (_isBack)
                return (char) _lastChar;

            return (char) _stream.Peek();
        }

        public void Back()
        {
            _isBack = true;
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }
}