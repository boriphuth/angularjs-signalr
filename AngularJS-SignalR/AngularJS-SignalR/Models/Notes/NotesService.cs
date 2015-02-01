﻿using System.Collections.Generic;
using System.Linq;

namespace AngularJS_SignalR.Models.Notes
{
    public class NotesService
    {
        public class IdentifierProvider
        {
            private static int id;
            public static int GetNewId()
            {
                return ++id;
            }
        }

        private static readonly List<Note> notesList = new List<Note>();

        public static bool Remove(int noteId)
        {
            var noteToRemove = notesList.SingleOrDefault(note => note.Id == noteId);
            return noteToRemove != null && notesList.Remove(noteToRemove);
        }

        public static Note Add(string note)
        {
            var newNote = new Note(note);
            notesList.Add(newNote);

            return newNote;
        }
    }
}