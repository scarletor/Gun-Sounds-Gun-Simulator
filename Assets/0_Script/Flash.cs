using AndroidNativeCore;
using UnityEngine;

class FlashNative
{
    Flash flash;
    void FlashOn()
    {
        flash = new Flash();

        //logic
        if (flash.isFlashAvailable())
        {
            //turn on flash
            flash.setFlashEnable(true);
            //turn off flash
            //flash.setFlashEnable(false);
        }
    }
}