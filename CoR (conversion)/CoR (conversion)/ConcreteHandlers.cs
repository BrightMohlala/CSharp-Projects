public class ToByte : AHandler
{
    public override dynamic Cast(string s_input)
    {
        if (byte.TryParse(s_input, out byte input))
            return input;
        else
            return successor.Cast(s_input);
    } //Cast
} //ToByte

public class ToShort : AHandler
{
    public override dynamic Cast(string s_input)
    {
        if (short.TryParse(s_input, out short input))
            return input;
        else
            return successor.Cast(s_input);
    } //Cast
} //ToShort

public class ToInt : AHandler
{
    public override dynamic Cast(string s_input)
    {
        if (int.TryParse(s_input, out int input))
            return input;
        else
            return successor.Cast(s_input);
    } //Cast
} //ToInt

public class ToFloat : AHandler
{
    public override dynamic Cast(string s_input)
    {
        if (float.TryParse(s_input, out float input) && input < float.MaxValue)
            return input;
        else
            return successor.Cast(s_input);
    } //Cast
} //ToFloat

public class ToDouble : AHandler
{
    public override dynamic Cast(string s_input)
    {
        if (double.TryParse(s_input, out double input))
            return input;
        else
            return successor.Cast(s_input);
    } //Cast
} //ToDouble

public class ToString : AHandler
{
    public override dynamic Cast(string s_input)
    {
        return s_input;
    } //Cast
} //ToString

