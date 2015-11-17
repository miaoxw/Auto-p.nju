#Auto p.nju
This project was written because Cee coded a plugin applicable for Mac, but Windows operating systems don't have such a tool yet. So, I spent a midnight finishing the first version.

If possible, I'll continue to develop this small project ,trying to make it easier and simpler.
##Finished Features
* Auto login
* Auto re-connect when BRAS disconnected
* Save username and password  
*Multi-user support is of course unnecessary, isn't it?*
* Show login state

##Update Log
###2015-11-17
* Auto-reconnect works again
* Fixed the no-responding problem when wrong username/password is input
* Fixed the UI problem when login time turns to the longest format like `2015/11/17 12:33:18`

###2015-07-25
* Update login logic according to the change of log-in methods made by NIC  
PS: This change is really awful...

###2015-06-18
* The exception dosen't appear any more
* *But the login speed is decreased*

###2015-06-14
* It seems that the exception raised when tool starts up is not solved?


###2015-06-13(2nd update)
* Fixed the problem that when BRAS service is auto logged in, Auto p.nju may get the online status of NULL and a NullReferenceException will be raised.

###2015-06-13
* Update this tool according to the change of log in methods made by NIC
* Fixed the problems that auto log in works malfunctionally

##To-do List
* Seperate the login process to a new thread to speed up
* Develop a GUI-less version, such as a Windows service

##See Also
* [Mac OS](https://github.com/Cee/PNJU-TodayWidget)
* [iOS&Apple Watch](https://github.com/Cee/PNJU-Watch)
* [Workflow](https://github.com/Cee/PNJU-Workflow)
