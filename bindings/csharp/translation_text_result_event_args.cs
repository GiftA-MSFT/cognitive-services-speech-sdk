//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System;

namespace Carbon.Recognition.Translation
{
    /// <summary>
    /// Define payload of translation intermediate/final result events.
    /// </summary>
    public class TranslationTextResultEventArgs : System.EventArgs
    {
        internal TranslationTextResultEventArgs(Carbon.Internal.TranslationTextResultEventArgs e)
        {
            this.Result = new TranslationTextResult(e.Result);
            this.SessionId = e.SessionId;
        }

        /// <summary>
        /// Specifies the recognition result.
        /// </summary>
        public TranslationTextResult Result { get; }

        /// <summary>
        /// Specifies the session identifier.
        /// </summary>
        public string SessionId { get; }

        /// <summary>
        /// Returns a string that represents the speech recognition result event.
        /// </summary>
        /// <returns>A string that represents the speech recognition result event.</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}