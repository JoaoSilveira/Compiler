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

        public int Line { get; private set; }
        public int Column { get; private set; }

        public CustomStream(StreamReader stream)
        {
            _stream = stream;
            Line = 1;
            Column = 1;
        }

        public void Next()
        {
            Column++;
            if (_isBack)
            {
                _isBack = false;
                return;
            }

            _lastChar = _stream.Read();

            if (_lastChar != '\n') return;

            Line++;
            Column = 1;
        }

        public char Peek()
        {
            if (_isBack)
                return (char)_lastChar;

            return (char)_stream.Peek();
        }

        public void Back()
        {
            _isBack = true;
            Column--;
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }
}