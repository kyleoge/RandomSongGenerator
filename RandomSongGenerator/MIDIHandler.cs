using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSongGenerator
{


    /*
     * 
     * This class is essentially a collection of functions that allow for simpler handling of MIDI files
     * 
     */



    public static class MIDIHandler
    {

        //MIDI files begin with a Header Chunk, which contains basic information about the file
        public static byte[] CreateHeaderChunk()
        {

            /*
             * A MIDI header chunk is divided into bytes as so:
             * | Chunk Type |  Length  |   Data  |
             * |  4 Bytes   | 4 Bytes  | 6 Bytes |
             */

            byte[] data = new byte[0];




            //The chunk type for a header is always "MThd". This indicates that the chunk is a header chunk.
            byte[] ChunkType = new byte[4];
            ChunkType = ASCIIEncoding.ASCII.GetBytes("MThd");

            //Length defines the size of the data portion of the chunk, which is always 6.
            byte[] Length = { 0, 0, 0, 6 };

            Debug.WriteLine(BitConverter.ToString(Length));

            return data;

        }

    }
}
