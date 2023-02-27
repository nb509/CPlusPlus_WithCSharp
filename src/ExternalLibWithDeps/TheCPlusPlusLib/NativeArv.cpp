#include "pch.h"
#include "NativeArv.h"
#include "dependencies/Aravis/include/arv.h"

void UpdateDeviceList()
{
	arv_update_device_list();
}

void GetNDevices(int& result)
{
	result = arv_get_n_devices();
}