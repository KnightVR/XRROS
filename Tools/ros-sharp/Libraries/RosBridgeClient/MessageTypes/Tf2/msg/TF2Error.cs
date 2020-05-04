/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Tf2
{
    public class TF2Error : Message
    {
        public const string RosMessageName = "tf2_msgs/TF2Error";

        public const byte NO_ERROR = 0;
        public const byte LOOKUP_ERROR = 1;
        public const byte CONNECTIVITY_ERROR = 2;
        public const byte EXTRAPOLATION_ERROR = 3;
        public const byte INVALID_ARGUMENT_ERROR = 4;
        public const byte TIMEOUT_ERROR = 5;
        public const byte TRANSFORM_ERROR = 6;
        public byte error { get; set; }
        public string error_string { get; set; }

        public TF2Error()
        {
            this.error = 0;
            this.error_string = "";
        }

        public TF2Error(byte error, string error_string)
        {
            this.error = error;
            this.error_string = error_string;
        }
    }
}
