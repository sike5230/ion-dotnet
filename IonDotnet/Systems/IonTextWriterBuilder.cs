﻿using System.IO;
using IonDotnet.Internals.Text;
using IonDotnet.Utils;

namespace IonDotnet.Systems
{
    public static class IonTextWriterBuilder
    {
        /// <summary>
        /// Build an Ion text writer
        /// </summary>
        /// <param name="textWriter">Writer that can write to the output</param>
        /// <returns>Ion text writer</returns>
        public static IIonWriter Build(TextWriter textWriter)
        {
            return new IonTextWriter(textWriter);
        }

        /// <summary>
        /// Build an Ion text writer
        /// </summary>
        /// <param name="textWriter">Writer that can write to the output</param>
        /// <param name="options">Text writer options</param>
        /// <returns>Ion text writer</returns>
        public static IIonWriter Build(TextWriter textWriter, IonTextOptions options)
        {
            return new IonTextWriter(textWriter, options);
        }
    }
}
