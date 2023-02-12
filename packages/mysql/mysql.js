var mysql = require('mysql');
const { INFO, WARNING, ERROR } = require('../common/logs');
module.exports =
{
    handle: null,

    connect: function(call){
        this.handle = mysql.createConnection({
            host     : 'localhost',
            user     : 'root',
            password : '',
            database : 'database'
        });

        this.handle.connect(function (err){
            if(err){
                switch(err.code){
                    case "ECONNREFUSED":
                        WARNING("\x1b[93m[MySQL] \x1b[97mError: Check your connection details (packages/mysql/mysql.js) or make sure your MySQL server is running. \x1b[39m");
                        break;
                    case "ER_BAD_DB_ERROR":
                        WARNING("\x1b[91m[MySQL] \x1b[97mError: The database name you've entered does not exist. \x1b[39m");
                        break;
                    case "ER_ACCESS_DENIED_ERROR":
                        WARNING("\x1b[91m[MySQL] \x1b[97mError: Check your MySQL username and password and make sure they're correct. \x1b[39m");
                        break;
                    case "ENOENT":
                        WARNING("\x1b[91m[MySQL] \x1b[97mError: There is no internet connection. Check your connection and try again. \x1b[39m")
                        break;
                    default:
                        ERROR("\x1b[91m[MySQL] \x1b[97mError: " + err.code + " \x1b[39m");
                        break;
                }
            } else {
                INFO("\x1b[92m[MySQL] \x1b[97mConnected Successfully \x1b[39m");
            }
        });
    }
};