

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int COM_HEX_EQUIPMENT_GPIO_GETINPUTSTATES_REQ_MAX_PACK_SIZE = 0;
        public const ulong COM_HEX_EQUIPMENT_GPIO_GETINPUTSTATES_REQ_DT_SIG = 0x6147C4FB7586515E;

        public const int COM_HEX_EQUIPMENT_GPIO_GETINPUTSTATES_REQ_DT_ID = 225;






        public partial class com_hex_equipment_gpio_GetInputStates_req: IDroneCANSerialize {




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_com_hex_equipment_gpio_GetInputStates_req(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_com_hex_equipment_gpio_GetInputStates_req(transfer, this);
            }
        }
    }
}
