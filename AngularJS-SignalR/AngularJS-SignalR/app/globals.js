﻿function signalR() {
}

// connected event
signalR.onConnected = "signalRConnected";

function notesSignalR() {
}

// hub
notesSignalR.hubName = "notesHub";

// client calls
notesSignalR.addNote = "addNote";
notesSignalR.removeNote = "removeNote";

// client callbacks
notesSignalR.onNewNote = "broadcastNewNote";
notesSignalR.onRemoveNote = "broadcastRemoveNote";



