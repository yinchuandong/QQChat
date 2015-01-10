Instant messaging desktop application for windows
================

### Introduction: 
    An instant messaging tool implemented in C# and designed in three-tier architecture, support online group chat 
### Functions:
    1.  	Register and login, needed be verified by email
    2.  	Follow friends and create groups
    3.  	Customize personalized avatar
    4.  	Allow to send customized expression and picture while chatting
    5.  	Save the chat logs to local file
### Technologies:
    1.	Use SQL Sever 2008 as the server database
    2.	Create a socket queue between each two user to implement P2P chat
    3.	Create a socket queue in server to dispatch the message to implement group chat
    4.	Serialize the object to transmit the data in socket
    5.	Use events delegate to update user interface from different threads


