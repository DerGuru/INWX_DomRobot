using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot
{
    /* 
     1000
Command completed successfully

1001
Command completed successfully; action pending

1300
Command completed successfully; no messages

1301
Command completed successfully; ack to dequeue

1500
Command completed successfully; ending session

1200
Password doesn't match

2000
Unknown command

2001
Command syntax error

2002
Command use error

2003
Required parameter missing

2004
Parameter value range error

2005
Parameter value syntax error

2101
Unimplemented command

2102
Unimplemented option

2103
Unimplemented extension

2104
Billing failure

2105
Object is not eligible for renewal

2106
Object is not eligible for transfer

2200
Authentication error

2201
Authorization error

2202
Invalid authorization information

2300
Object pending transfer

2301
Object not pending transfer

2302
Object exists

2303
Object does not exist

2304
Object status prohibits operation

2305
Object association prohibits operation

2306
Parameter value policy error

2307
Unimplemented object service

2308
Data management policy violation

2400
Command failed

2500
Command failed; server closing connection

2501
Authentication error; server closing connection

2502
Session limit exceeded; server closing connection*/
    public enum ResultCode
    {
        CommandCompletedSuccessfully = 1000,
        CommandCompletedSuccessfullyActionPending = 1001,
        CommandCompletedSuccessfullyNoMessages = 1300,
        CommandCompletedSuccessfullyAckToDequeue = 1301,
        CommandCompletedSuccessfullyEndingSession = 1500,
        PasswordDoesNotMatch = 1200,

        UnknownCommand = 2000,
        CommandSyntaxError = 2001,
        CommandUseError = 2002,
        RequiredParameterMissing = 2003,
        ParameterValueRangeError = 2004,
        ParameterValueSyntaxError = 2005,

        UnimplementedCommand = 2101,
        UnimplementedOption = 2102,
        UnimplementedExtension = 2103,
        BillingFailure = 2104,
        ObjectNotEligibleForRenewal = 2105,
        ObjectNotEligibleForTransfer = 2106,

        AuthenticationError = 2200,
        AuthorizationError = 2201,
        InvalidAuthorizationInformation = 2202,

        ObjectPendingTransfer = 2300,
        ObjectNotPendingTransfer = 2301,
        ObjectExists = 2302,
        ObjectDoesNotExist = 2303,
        ObjectStatusProhibitsOperation = 2304,
        ObjectAssociationProhibitsOperation = 2305,
        ParameterValuePolicyError = 2306,
        UnimplementedObjectService = 2307,
        DataManagementPolicyViolation = 2308,

        CommandFailed = 2400,

        CommandFailedServerClosingConnection = 2500,
        AuthenticationErrorServerClosingConnection = 2501,
        SessionLimitExeededServerClosingConnection = 2502
    }
}
