module.exports =  
{
    INFO: function(message) {
        console.log("\x1b[92m[INFO] \x1b[97m" + message + " \x1b[39m")
    },

    WARNING: function(message) {
        console.log("\x1b[38;5;214m[WARNING] \x1b[97m" + message + " \x1b[39m")
    },

    ERROR: function(message) {
        console.log("\x1b[91m[ERROR] \x1b[97m" + message + " \x1b[39m")
    }
}