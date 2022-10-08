import {ipcRenderer, contextBridge} from "electron";
import {cpus} from "os";

contextBridge.exposeInMainWorld("api", {
    threads: cpus().length
});

console.log("CPUs loaded from `os`:", cpus().length)