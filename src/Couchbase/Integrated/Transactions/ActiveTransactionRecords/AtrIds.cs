#nullable enable
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Couchbase.Core.Sharding;

namespace Couchbase.Integrated.Transactions.ActiveTransactionRecords
{
    internal static class AtrIds
    {
        // ATR contention
        public const int NUM_VBUCKETS = 1024;

        // Default number of ATRs discussed on TXNJ-122
        public const int NUM_ATRS_DEFAULT = NUM_VBUCKETS;

        // TXNJ-112: Currently have 20 blocks available, can increase if needed
        public const int MAX_ATR_BLOCKS = 20;
        public const int MAX_ATRS = 1024 * MAX_ATR_BLOCKS;
        private const int VBucketPartitionCount = 1024;
        private static readonly short VBucketMask = VBucketMapper.GetMask(VBucketPartitionCount);

        private static readonly ReadOnlyCollection<string> AllAtrIds = new( new []
        {
            "_txn:atr-0-#14",
            "_txn:atr-1-#10b6",
            "_txn:atr-2-#cc8",
            "_txn:atr-3-#f08",
            "_txn:atr-4-#c7",
            "_txn:atr-5-#11a",
            "_txn:atr-6-#a",
            "_txn:atr-7-#2c4",
            "_txn:atr-8-#4c",
            "_txn:atr-9-#0",
            "_txn:atr-10-#b8a",
            "_txn:atr-11-#89e",
            "_txn:atr-12-#ba8",
            "_txn:atr-13-#129e",
            "_txn:atr-14-#1429",
            "_txn:atr-15-#39c8",
            "_txn:atr-16-#1d8",
            "_txn:atr-17-#2e8",
            "_txn:atr-18-#1179",
            "_txn:atr-19-#28",
            "_txn:atr-20-#c68",
            "_txn:atr-21-#fe8",
            "_txn:atr-22-#59e8",
            "_txn:atr-23-#a4",
            "_txn:atr-24-#20c",
            "_txn:atr-25-#11c",
            "_txn:atr-26-#1b6",
            "_txn:atr-27-#2c6",
            "_txn:atr-28-#122a",
            "_txn:atr-29-#123e",
            "_txn:atr-30-#22",
            "_txn:atr-31-#28d",
            "_txn:atr-32-#183d",
            "_txn:atr-33-#1861",
            "_txn:atr-34-#b3",
            "_txn:atr-35-#f19",
            "_txn:atr-36-#b61",
            "_txn:atr-37-#83d",
            "_txn:atr-38-#b26",
            "_txn:atr-39-#832",
            "_txn:atr-40-#b94",
            "_txn:atr-41-#4d",
            "_txn:atr-42-#836",
            "_txn:atr-43-#5",
            "_txn:atr-44-#118",
            "_txn:atr-45-#b6",
            "_txn:atr-46-#1222",
            "_txn:atr-47-#1236",
            "_txn:atr-48-#199",
            "_txn:atr-49-#289",
            "_txn:atr-50-#21b",
            "_txn:atr-51-#10b",
            "_txn:atr-52-#bd",
            "_txn:atr-53-#159",
            "_txn:atr-54-#8a9",
            "_txn:atr-55-#1206",
            "_txn:atr-56-#bc1",
            "_txn:atr-57-#8b5",
            "_txn:atr-58-#c24",
            "_txn:atr-59-#8bc",
            "_txn:atr-60-#181",
            "_txn:atr-61-#291",
            "_txn:atr-62-#227",
            "_txn:atr-63-#137",
            "_txn:atr-64-#cd9",
            "_txn:atr-65-#c9",
            "_txn:atr-66-#929",
            "_txn:atr-67-#18cd",
            "_txn:atr-68-#8d",
            "_txn:atr-69-#81c",
            "_txn:atr-70-#888",
            "_txn:atr-71-#121c",
            "_txn:atr-72-#bbc",
            "_txn:atr-73-#924",
            "_txn:atr-74-#136",
            "_txn:atr-75-#226",
            "_txn:atr-76-#10b9",
            "_txn:atr-77-#58b8",
            "_txn:atr-78-#619",
            "_txn:atr-79-#3b9",
            "_txn:atr-80-#b1a",
            "_txn:atr-81-#80e",
            "_txn:atr-82-#8c0",
            "_txn:atr-83-#bb4",
            "_txn:atr-84-#1349",
            "_txn:atr-85-#3878",
            "_txn:atr-86-#3b8",
            "_txn:atr-87-#618",
            "_txn:atr-88-#2cd",
            "_txn:atr-89-#1bd",
            "_txn:atr-90-#1324",
            "_txn:atr-91-#12bc",
            "_txn:atr-92-#12f",
            "_txn:atr-93-#23f",
            "_txn:atr-94-#bc3",
            "_txn:atr-95-#8b7",
            "_txn:atr-96-#79",
            "_txn:atr-97-#ff9",
            "_txn:atr-98-#1bc7",
            "_txn:atr-99-#8e8",
            "_txn:atr-100-#bc0",
            "_txn:atr-101-#8b4",
            "_txn:atr-102-#81a",
            "_txn:atr-103-#b0e",
            "_txn:atr-104-#248",
            "_txn:atr-105-#158",
            "_txn:atr-106-#42",
            "_txn:atr-107-#18b4",
            "_txn:atr-108-#215",
            "_txn:atr-109-#105",
            "_txn:atr-110-#1217",
            "_txn:atr-111-#1203",
            "_txn:atr-112-#119",
            "_txn:atr-113-#209",
            "_txn:atr-114-#f1",
            "_txn:atr-115-#8e9",
            "_txn:atr-116-#b95",
            "_txn:atr-117-#881",
            "_txn:atr-118-#b9c",
            "_txn:atr-119-#8de",
            "_txn:atr-120-#2a3",
            "_txn:atr-121-#1db",
            "_txn:atr-122-#f8",
            "_txn:atr-123-#22f",
            "_txn:atr-124-#859",
            "_txn:atr-125-#1d29",
            "_txn:atr-126-#bc9",
            "_txn:atr-127-#ab9",
            "_txn:atr-128-#288",
            "_txn:atr-129-#198",
            "_txn:atr-130-#10c",
            "_txn:atr-131-#21c",
            "_txn:atr-132-#158",
            "_txn:atr-133-#248",
            "_txn:atr-134-#1805",
            "_txn:atr-135-#8a8",
            "_txn:atr-136-#56",
            "_txn:atr-137-#bc0",
            "_txn:atr-138-#8bb",
            "_txn:atr-139-#bcf",
            "_txn:atr-140-#b21",
            "_txn:atr-141-#835",
            "_txn:atr-142-#883",
            "_txn:atr-143-#38",
            "_txn:atr-144-#171",
            "_txn:atr-145-#261",
            "_txn:atr-146-#29f",
            "_txn:atr-147-#4d",
            "_txn:atr-148-#181d",
            "_txn:atr-149-#1841",
            "_txn:atr-150-#2b4",
            "_txn:atr-151-#1c4",
            "_txn:atr-152-#728",
            "_txn:atr-153-#2a8",
            "_txn:atr-154-#c3",
            "_txn:atr-155-#848",
            "_txn:atr-156-#b46",
            "_txn:atr-157-#81c",
            "_txn:atr-158-#b01",
            "_txn:atr-159-#815",
            "_txn:atr-160-#116",
            "_txn:atr-161-#206",
            "_txn:atr-162-#2cc",
            "_txn:atr-163-#13",
            "_txn:atr-164-#5",
            "_txn:atr-165-#ad8",
            "_txn:atr-166-#838",
            "_txn:atr-167-#c0",
            "_txn:atr-168-#8c7",
            "_txn:atr-169-#bb3",
            "_txn:atr-170-#b5",
            "_txn:atr-171-#8",
            "_txn:atr-172-#b21",
            "_txn:atr-173-#835",
            "_txn:atr-174-#1cd",
            "_txn:atr-175-#2bd",
            "_txn:atr-176-#171",
            "_txn:atr-177-#261",
            "_txn:atr-178-#136",
            "_txn:atr-179-#b6",
            "_txn:atr-180-#ba3",
            "_txn:atr-181-#88d",
            "_txn:atr-182-#4e",
            "_txn:atr-183-#b2f",
            "_txn:atr-184-#3c9",
            "_txn:atr-185-#609",
            "_txn:atr-186-#1f68",
            "_txn:atr-187-#19e8",
            "_txn:atr-188-#236",
            "_txn:atr-189-#126",
            "_txn:atr-190-#12c9",
            "_txn:atr-191-#c2",
            "_txn:atr-192-#1c2",
            "_txn:atr-193-#2b2",
            "_txn:atr-194-#b66",
            "_txn:atr-195-#4f",
            "_txn:atr-196-#12b4",
            "_txn:atr-197-#868",
            "_txn:atr-198-#39",
            "_txn:atr-199-#f59",
            "_txn:atr-200-#13c",
            "_txn:atr-201-#4b",
            "_txn:atr-202-#29e",
            "_txn:atr-203-#d",
            "_txn:atr-204-#1021",
            "_txn:atr-205-#b0",
            "_txn:atr-206-#a58",
            "_txn:atr-207-#b48",
            "_txn:atr-208-#4a",
            "_txn:atr-209-#9c9",
            "_txn:atr-210-#8cb",
            "_txn:atr-211-#bbf",
            "_txn:atr-212-#bb",
            "_txn:atr-213-#1820",
            "_txn:atr-214-#239",
            "_txn:atr-215-#129",
            "_txn:atr-216-#115",
            "_txn:atr-217-#89",
            "_txn:atr-218-#11c",
            "_txn:atr-219-#20c",
            "_txn:atr-220-#b2f",
            "_txn:atr-221-#83b",
            "_txn:atr-222-#88d",
            "_txn:atr-223-#ba3",
            "_txn:atr-224-#1b00",
            "_txn:atr-225-#349",
            "_txn:atr-226-#1458",
            "_txn:atr-227-#39d9",
            "_txn:atr-228-#c5",
            "_txn:atr-229-#284",
            "_txn:atr-230-#1f29",
            "_txn:atr-231-#19a9",
            "_txn:atr-232-#13c",
            "_txn:atr-233-#22c",
            "_txn:atr-234-#bb6",
            "_txn:atr-235-#8c2",
            "_txn:atr-236-#1b66",
            "_txn:atr-237-#8b8",
            "_txn:atr-238-#c29",
            "_txn:atr-239-#fa9",
            "_txn:atr-240-#8b7",
            "_txn:atr-241-#bc3",
            "_txn:atr-242-#b0f",
            "_txn:atr-243-#81b",
            "_txn:atr-244-#1168",
            "_txn:atr-245-#5969",
            "_txn:atr-246-#729",
            "_txn:atr-247-#2a9",
            "_txn:atr-248-#106",
            "_txn:atr-249-#216",
            "_txn:atr-250-#c",
            "_txn:atr-251-#38",
            "_txn:atr-252-#2a4",
            "_txn:atr-253-#1de",
            "_txn:atr-254-#80e",
            "_txn:atr-255-#b1a",
            "_txn:atr-256-#b11",
            "_txn:atr-257-#805",
            "_txn:atr-258-#b56",
            "_txn:atr-259-#1b",
            "_txn:atr-260-#12b",
            "_txn:atr-261-#23b",
            "_txn:atr-262-#28d",
            "_txn:atr-263-#19d",
            "_txn:atr-264-#ff9",
            "_txn:atr-265-#c59",
            "_txn:atr-266-#85",
            "_txn:atr-267-#9c9",
            "_txn:atr-268-#880",
            "_txn:atr-269-#b94",
            "_txn:atr-270-#59",
            "_txn:atr-271-#1811",
            "_txn:atr-272-#b88",
            "_txn:atr-273-#a98",
            "_txn:atr-274-#2e",
            "_txn:atr-275-#128e",
            "_txn:atr-276-#104",
            "_txn:atr-277-#214",
            "_txn:atr-278-#10b",
            "_txn:atr-279-#21b",
            "_txn:atr-280-#896",
            "_txn:atr-281-#b82",
            "_txn:atr-282-#b34",
            "_txn:atr-283-#3b",
            "_txn:atr-284-#18e8",
            "_txn:atr-285-#1ad8",
            "_txn:atr-286-#1124",
            "_txn:atr-287-#92",
            "_txn:atr-288-#261",
            "_txn:atr-289-#171",
            "_txn:atr-290-#1f9",
            "_txn:atr-291-#459",
            "_txn:atr-292-#1cb",
            "_txn:atr-293-#2bb",
            "_txn:atr-294-#b27",
            "_txn:atr-295-#833",
            "_txn:atr-296-#f79",
            "_txn:atr-297-#cd9",
            "_txn:atr-298-#848",
            "_txn:atr-299-#1036",
            "_txn:atr-300-#bc4",
            "_txn:atr-301-#8b0",
            "_txn:atr-302-#81e",
            "_txn:atr-303-#b0a",
            "_txn:atr-304-#1be",
            "_txn:atr-305-#2ce",
            "_txn:atr-306-#200",
            "_txn:atr-307-#9d",
            "_txn:atr-308-#1c9",
            "_txn:atr-309-#2b9",
            "_txn:atr-310-#231",
            "_txn:atr-311-#121",
            "_txn:atr-312-#1882",
            "_txn:atr-313-#1896",
            "_txn:atr-314-#21",
            "_txn:atr-315-#ae9",
            "_txn:atr-316-#b91",
            "_txn:atr-317-#885",
            "_txn:atr-318-#ba4",
            "_txn:atr-319-#88c",
            "_txn:atr-320-#1c7",
            "_txn:atr-321-#2b7",
            "_txn:atr-322-#21b",
            "_txn:atr-323-#c5",
            "_txn:atr-324-#b79",
            "_txn:atr-325-#a69",
            "_txn:atr-326-#8a9",
            "_txn:atr-327-#16",
            "_txn:atr-328-#816",
            "_txn:atr-329-#b02",
            "_txn:atr-330-#4b",
            "_txn:atr-331-#1959",
            "_txn:atr-332-#b8c",
            "_txn:atr-333-#8a4",
            "_txn:atr-334-#b0",
            "_txn:atr-335-#20e",
            "_txn:atr-336-#192",
            "_txn:atr-337-#282",
            "_txn:atr-338-#c",
            "_txn:atr-339-#4a",
            "_txn:atr-340-#13",
            "_txn:atr-341-#141",
            "_txn:atr-342-#1c5",
            "_txn:atr-343-#2b5",
            "_txn:atr-344-#bb9",
            "_txn:atr-345-#ac9",
            "_txn:atr-346-#849",
            "_txn:atr-347-#180a",
            "_txn:atr-348-#4d",
            "_txn:atr-349-#8ba",
            "_txn:atr-350-#878",
            "_txn:atr-351-#12bf",
            "_txn:atr-352-#86",
            "_txn:atr-353-#b1e",
            "_txn:atr-354-#29c",
            "_txn:atr-355-#18c",
            "_txn:atr-356-#2f",
            "_txn:atr-357-#6f8",
            "_txn:atr-358-#1bc2",
            "_txn:atr-359-#1bb6",
            "_txn:atr-360-#11d8",
            "_txn:atr-361-#898",
            "_txn:atr-362-#f58",
            "_txn:atr-363-#cf8",
            "_txn:atr-364-#5",
            "_txn:atr-365-#210",
            "_txn:atr-366-#2be",
            "_txn:atr-367-#1ce",
            "_txn:atr-368-#181",
            "_txn:atr-369-#291",
            "_txn:atr-370-#3a9",
            "_txn:atr-371-#629",
            "_txn:atr-372-#251",
            "_txn:atr-373-#141",
            "_txn:atr-374-#88b",
            "_txn:atr-375-#b9f",
            "_txn:atr-376-#bb9",
            "_txn:atr-377-#bd",
            "_txn:atr-378-#121d",
            "_txn:atr-379-#928",
            "_txn:atr-380-#639",
            "_txn:atr-381-#529",
            "_txn:atr-382-#1bc6",
            "_txn:atr-383-#1bb2",
            "_txn:atr-384-#1429",
            "_txn:atr-385-#39c8",
            "_txn:atr-386-#71",
            "_txn:atr-387-#6d9",
            "_txn:atr-388-#112",
            "_txn:atr-389-#202",
            "_txn:atr-390-#348",
            "_txn:atr-391-#1014",
            "_txn:atr-392-#1c6",
            "_txn:atr-393-#2b6",
            "_txn:atr-394-#b2c",
            "_txn:atr-395-#85",
            "_txn:atr-396-#b78",
            "_txn:atr-397-#a68",
            "_txn:atr-398-#1b8d",
            "_txn:atr-399-#1ba3",
            "_txn:atr-400-#22f",
            "_txn:atr-401-#13f",
            "_txn:atr-402-#1db",
            "_txn:atr-403-#1",
            "_txn:atr-404-#ab9",
            "_txn:atr-405-#bc9",
            "_txn:atr-406-#1923",
            "_txn:atr-407-#19",
            "_txn:atr-408-#b80",
            "_txn:atr-409-#894",
            "_txn:atr-410-#f38",
            "_txn:atr-411-#e28",
            "_txn:atr-412-#81e",
            "_txn:atr-413-#b0a",
            "_txn:atr-414-#2de",
            "_txn:atr-415-#1a4",
            "_txn:atr-416-#1149",
            "_txn:atr-417-#5948",
            "_txn:atr-418-#329",
            "_txn:atr-419-#c3",
            "_txn:atr-420-#888",
            "_txn:atr-421-#1179",
            "_txn:atr-422-#e58",
            "_txn:atr-423-#f48",
            "_txn:atr-424-#136",
            "_txn:atr-425-#226",
            "_txn:atr-426-#27",
            "_txn:atr-427-#180",
            "_txn:atr-428-#619",
            "_txn:atr-429-#3b9",
            "_txn:atr-430-#c9",
            "_txn:atr-431-#1cb",
            "_txn:atr-432-#22f",
            "_txn:atr-433-#13f",
            "_txn:atr-434-#de",
            "_txn:atr-435-#bb3",
            "_txn:atr-436-#ab9",
            "_txn:atr-437-#bc9",
            "_txn:atr-438-#938",
            "_txn:atr-439-#12be",
            "_txn:atr-440-#9d8",
            "_txn:atr-441-#22",
            "_txn:atr-442-#c28",
            "_txn:atr-443-#fa8",
            "_txn:atr-444-#292",
            "_txn:atr-445-#8b",
            "_txn:atr-446-#134",
            "_txn:atr-447-#224",
            "_txn:atr-448-#b9",
            "_txn:atr-449-#108c",
            "_txn:atr-450-#113",
            "_txn:atr-451-#203",
            "_txn:atr-452-#109",
            "_txn:atr-453-#219",
            "_txn:atr-454-#79a8",
            "_txn:atr-455-#8d9",
            "_txn:atr-456-#8cd",
            "_txn:atr-457-#2c",
            "_txn:atr-458-#8c2",
            "_txn:atr-459-#bb6",
            "_txn:atr-460-#2db",
            "_txn:atr-461-#b3",
            "_txn:atr-462-#12f",
            "_txn:atr-463-#23f",
            "_txn:atr-464-#895",
            "_txn:atr-465-#b81",
            "_txn:atr-466-#b37",
            "_txn:atr-467-#823",
            "_txn:atr-468-#e",
            "_txn:atr-469-#1bdb",
            "_txn:atr-470-#b06",
            "_txn:atr-471-#812",
            "_txn:atr-472-#f58",
            "_txn:atr-473-#d8",
            "_txn:atr-474-#12a9",
            "_txn:atr-475-#39b8",
            "_txn:atr-476-#2be",
            "_txn:atr-477-#1ce",
            "_txn:atr-478-#2b3",
            "_txn:atr-479-#1c3",
            "_txn:atr-480-#9e",
            "_txn:atr-481-#b34",
            "_txn:atr-482-#b82",
            "_txn:atr-483-#1",
            "_txn:atr-484-#35",
            "_txn:atr-485-#1b95",
            "_txn:atr-486-#13f9",
            "_txn:atr-487-#38e8",
            "_txn:atr-488-#8c",
            "_txn:atr-489-#29b",
            "_txn:atr-490-#209",
            "_txn:atr-491-#119",
            "_txn:atr-492-#2b",
            "_txn:atr-493-#103",
            "_txn:atr-494-#881",
            "_txn:atr-495-#b95",
            "_txn:atr-496-#80f",
            "_txn:atr-497-#b1b",
            "_txn:atr-498-#800",
            "_txn:atr-499-#b14",
            "_txn:atr-500-#cb",
            "_txn:atr-501-#8f8",
            "_txn:atr-502-#a18",
            "_txn:atr-503-#b08",
            "_txn:atr-504-#204",
            "_txn:atr-505-#99",
            "_txn:atr-506-#1ba",
            "_txn:atr-507-#2ca",
            "_txn:atr-508-#bd",
            "_txn:atr-509-#149",
            "_txn:atr-510-#193",
            "_txn:atr-511-#283",
            "_txn:atr-512-#6db",
            "_txn:atr-513-#2f1",
            "_txn:atr-514-#b25",
            "_txn:atr-515-#831",
            "_txn:atr-516-#5809",
            "_txn:atr-517-#1008",
            "_txn:atr-518-#b78",
            "_txn:atr-519-#a68",
            "_txn:atr-520-#3b9",
            "_txn:atr-521-#97",
            "_txn:atr-522-#1b24",
            "_txn:atr-523-#1b30",
            "_txn:atr-524-#8c1",
            "_txn:atr-525-#76",
            "_txn:atr-526-#b51",
            "_txn:atr-527-#80d",
            "_txn:atr-528-#94",
            "_txn:atr-529-#b66",
            "_txn:atr-530-#1b14",
            "_txn:atr-531-#938",
            "_txn:atr-532-#35",
            "_txn:atr-533-#8ca",
            "_txn:atr-534-#130",
            "_txn:atr-535-#220",
            "_txn:atr-536-#1a29",
            "_txn:atr-537-#1839",
            "_txn:atr-538-#529",
            "_txn:atr-539-#639",
            "_txn:atr-540-#18c0",
            "_txn:atr-541-#18b4",
            "_txn:atr-542-#3b",
            "_txn:atr-543-#169",
            "_txn:atr-544-#b71",
            "_txn:atr-545-#82d",
            "_txn:atr-546-#cc",
            "_txn:atr-547-#3",
            "_txn:atr-548-#1027",
            "_txn:atr-549-#838",
            "_txn:atr-550-#8b0",
            "_txn:atr-551-#bc4",
            "_txn:atr-552-#d28",
            "_txn:atr-553-#e",
            "_txn:atr-554-#2b08",
            "_txn:atr-555-#44",
            "_txn:atr-556-#146",
            "_txn:atr-557-#256",
            "_txn:atr-558-#101",
            "_txn:atr-559-#211",
            "_txn:atr-560-#c78",
            "_txn:atr-561-#fd8",
            "_txn:atr-562-#d",
            "_txn:atr-563-#1c79",
            "_txn:atr-564-#12e",
            "_txn:atr-565-#23e",
            "_txn:atr-566-#28c",
            "_txn:atr-567-#19c",
            "_txn:atr-568-#1816",
            "_txn:atr-569-#1802",
            "_txn:atr-570-#18d",
            "_txn:atr-571-#29d",
            "_txn:atr-572-#1221",
            "_txn:atr-573-#1235",
            "_txn:atr-574-#b49",
            "_txn:atr-575-#a59",
            "_txn:atr-576-#b0d",
            "_txn:atr-577-#851",
            "_txn:atr-578-#2d",
            "_txn:atr-579-#816",
            "_txn:atr-580-#1b7",
            "_txn:atr-581-#2c7",
            "_txn:atr-582-#20b",
            "_txn:atr-583-#85",
            "_txn:atr-584-#1876",
            "_txn:atr-585-#182c",
            "_txn:atr-586-#c69",
            "_txn:atr-587-#fe9",
            "_txn:atr-588-#806",
            "_txn:atr-589-#b12",
            "_txn:atr-590-#71",
            "_txn:atr-591-#ff8",
            "_txn:atr-592-#102b",
            "_txn:atr-593-#9d8",
            "_txn:atr-594-#198",
            "_txn:atr-595-#288",
            "_txn:atr-596-#182",
            "_txn:atr-597-#292",
            "_txn:atr-598-#18d",
            "_txn:atr-599-#3c",
            "_txn:atr-600-#48",
            "_txn:atr-601-#898",
            "_txn:atr-602-#f58",
            "_txn:atr-603-#cf8",
            "_txn:atr-604-#100",
            "_txn:atr-605-#5",
            "_txn:atr-606-#2be",
            "_txn:atr-607-#1ce",
            "_txn:atr-608-#1bb7",
            "_txn:atr-609-#cf",
            "_txn:atr-610-#2cf",
            "_txn:atr-611-#1bf",
            "_txn:atr-612-#1046",
            "_txn:atr-613-#14",
            "_txn:atr-614-#a39",
            "_txn:atr-615-#b29",
            "_txn:atr-616-#b15",
            "_txn:atr-617-#801",
            "_txn:atr-618-#b1c",
            "_txn:atr-619-#846",
            "_txn:atr-620-#12f",
            "_txn:atr-621-#23f",
            "_txn:atr-622-#2db",
            "_txn:atr-623-#1a3",
            "_txn:atr-624-#82",
            "_txn:atr-625-#823",
            "_txn:atr-626-#895",
            "_txn:atr-627-#b81",
            "_txn:atr-628-#cc8",
            "_txn:atr-629-#f08",
            "_txn:atr-630-#8f6",
            "_txn:atr-631-#bcc",
            "_txn:atr-632-#9e",
            "_txn:atr-633-#898",
            "_txn:atr-634-#668",
            "_txn:atr-635-#3e8",
            "_txn:atr-636-#35",
            "_txn:atr-637-#210",
            "_txn:atr-638-#10f",
            "_txn:atr-639-#21f",
            "_txn:atr-640-#f39",
            "_txn:atr-641-#c3",
            "_txn:atr-642-#1003",
            "_txn:atr-643-#969",
            "_txn:atr-644-#28f",
            "_txn:atr-645-#10",
            "_txn:atr-646-#161",
            "_txn:atr-647-#271",
            "_txn:atr-648-#3959",
            "_txn:atr-649-#b5",
            "_txn:atr-650-#266",
            "_txn:atr-651-#176",
            "_txn:atr-652-#19a9",
            "_txn:atr-653-#46",
            "_txn:atr-654-#ab8",
            "_txn:atr-655-#bc8",
            "_txn:atr-656-#828",
            "_txn:atr-657-#12d8",
            "_txn:atr-658-#f19",
            "_txn:atr-659-#cb9",
            "_txn:atr-660-#1458",
            "_txn:atr-661-#39d9",
            "_txn:atr-662-#6d8",
            "_txn:atr-663-#378",
            "_txn:atr-664-#9a",
            "_txn:atr-665-#8c2",
            "_txn:atr-666-#846",
            "_txn:atr-667-#b1c",
            "_txn:atr-668-#c29",
            "_txn:atr-669-#fa9",
            "_txn:atr-670-#83f",
            "_txn:atr-671-#b2b",
            "_txn:atr-672-#f39",
            "_txn:atr-673-#e29",
            "_txn:atr-674-#12c7",
            "_txn:atr-675-#12b3",
            "_txn:atr-676-#d",
            "_txn:atr-677-#19f",
            "_txn:atr-678-#280",
            "_txn:atr-679-#190",
            "_txn:atr-680-#b51",
            "_txn:atr-681-#80d",
            "_txn:atr-682-#8c1",
            "_txn:atr-683-#bb5",
            "_txn:atr-684-#2ce8",
            "_txn:atr-685-#39",
            "_txn:atr-686-#3b9",
            "_txn:atr-687-#619",
            "_txn:atr-688-#a9",
            "_txn:atr-689-#2938",
            "_txn:atr-690-#296",
            "_txn:atr-691-#186",
            "_txn:atr-692-#10f8",
            "_txn:atr-693-#58f9",
            "_txn:atr-694-#f68",
            "_txn:atr-695-#ce8",
            "_txn:atr-696-#b36",
            "_txn:atr-697-#1c",
            "_txn:atr-698-#b71",
            "_txn:atr-699-#82d",
            "_txn:atr-700-#18b1",
            "_txn:atr-701-#ba9",
            "_txn:atr-702-#5948",
            "_txn:atr-703-#879",
            "_txn:atr-704-#251",
            "_txn:atr-705-#141",
            "_txn:atr-706-#1c5",
            "_txn:atr-707-#2b5",
            "_txn:atr-708-#3e",
            "_txn:atr-709-#1016",
            "_txn:atr-710-#1de",
            "_txn:atr-711-#2a4",
            "_txn:atr-712-#2b8",
            "_txn:atr-713-#1c8",
            "_txn:atr-714-#878",
            "_txn:atr-715-#1a88",
            "_txn:atr-716-#82c",
            "_txn:atr-717-#b76",
            "_txn:atr-718-#825",
            "_txn:atr-719-#b31",
            "_txn:atr-720-#358",
            "_txn:atr-721-#ba",
            "_txn:atr-722-#1c48",
            "_txn:atr-723-#2879",
            "_txn:atr-724-#80a",
            "_txn:atr-725-#43",
            "_txn:atr-726-#bb0",
            "_txn:atr-727-#8c4",
            "_txn:atr-728-#1833",
            "_txn:atr-729-#9f9",
            "_txn:atr-730-#8b3",
            "_txn:atr-731-#bc7",
            "_txn:atr-732-#8c9",
            "_txn:atr-733-#15",
            "_txn:atr-734-#269",
            "_txn:atr-735-#179",
            "_txn:atr-736-#251",
            "_txn:atr-737-#a4",
            "_txn:atr-738-#216",
            "_txn:atr-739-#106",
            "_txn:atr-740-#192",
            "_txn:atr-741-#282",
            "_txn:atr-742-#234",
            "_txn:atr-743-#124",
            "_txn:atr-744-#a28",
            "_txn:atr-745-#b38",
            "_txn:atr-746-#1871",
            "_txn:atr-747-#90",
            "_txn:atr-748-#871",
            "_txn:atr-749-#b2d",
            "_txn:atr-750-#1294",
            "_txn:atr-751-#d",
            "_txn:atr-752-#b79",
            "_txn:atr-753-#a69",
            "_txn:atr-754-#1841",
            "_txn:atr-755-#71",
            "_txn:atr-756-#1c7",
            "_txn:atr-757-#2b7",
            "_txn:atr-758-#1ca",
            "_txn:atr-759-#2ba",
            "_txn:atr-760-#8cf",
            "_txn:atr-761-#bbb",
            "_txn:atr-762-#b17",
            "_txn:atr-763-#78",
            "_txn:atr-764-#2979",
            "_txn:atr-765-#1b48",
            "_txn:atr-766-#1e9",
            "_txn:atr-767-#99",
            "_txn:atr-768-#659",
            "_txn:atr-769-#3f9",
            "_txn:atr-770-#c3",
            "_txn:atr-771-#1c3",
            "_txn:atr-772-#2c9",
            "_txn:atr-773-#1b9",
            "_txn:atr-774-#10",
            "_txn:atr-775-#108d",
            "_txn:atr-776-#b41",
            "_txn:atr-777-#81d",
            "_txn:atr-778-#b5",
            "_txn:atr-779-#812",
            "_txn:atr-780-#1b3",
            "_txn:atr-781-#2c3",
            "_txn:atr-782-#20f",
            "_txn:atr-783-#4f",
            "_txn:atr-784-#bcb",
            "_txn:atr-785-#8bf",
            "_txn:atr-786-#813",
            "_txn:atr-787-#b07",
            "_txn:atr-788-#1929",
            "_txn:atr-789-#968",
            "_txn:atr-790-#822",
            "_txn:atr-791-#b4",
            "_txn:atr-792-#ce8",
            "_txn:atr-793-#f68",
            "_txn:atr-794-#1023",
            "_txn:atr-795-#1037",
            "_txn:atr-796-#186",
            "_txn:atr-797-#296",
            "_txn:atr-798-#1db",
            "_txn:atr-799-#c2",
            "_txn:atr-800-#729",
            "_txn:atr-801-#c1",
            "_txn:atr-802-#1b98",
            "_txn:atr-803-#2839",
            "_txn:atr-804-#b0f",
            "_txn:atr-805-#12",
            "_txn:atr-806-#8b7",
            "_txn:atr-807-#bc3",
            "_txn:atr-808-#828",
            "_txn:atr-809-#b7",
            "_txn:atr-810-#bb4",
            "_txn:atr-811-#8c0",
            "_txn:atr-812-#120e",
            "_txn:atr-813-#44",
            "_txn:atr-814-#618",
            "_txn:atr-815-#3b8",
            "_txn:atr-816-#1891",
            "_txn:atr-817-#79",
            "_txn:atr-818-#1b9",
            "_txn:atr-819-#2c9",
            "_txn:atr-820-#18cf",
            "_txn:atr-821-#c8",
            "_txn:atr-822-#a78",
            "_txn:atr-823-#b68",
            "_txn:atr-824-#9c",
            "_txn:atr-825-#13e",
            "_txn:atr-826-#18c",
            "_txn:atr-827-#29c",
            "_txn:atr-828-#239",
            "_txn:atr-829-#129",
            "_txn:atr-830-#1c1",
            "_txn:atr-831-#2b1",
            "_txn:atr-832-#188d",
            "_txn:atr-833-#18a3",
            "_txn:atr-834-#b69",
            "_txn:atr-835-#a79",
            "_txn:atr-836-#b3b",
            "_txn:atr-837-#82f",
            "_txn:atr-838-#b34",
            "_txn:atr-839-#820",
            "_txn:atr-840-#b86",
            "_txn:atr-841-#892",
            "_txn:atr-842-#824",
            "_txn:atr-843-#b30",
            "_txn:atr-844-#678",
            "_txn:atr-845-#3d8",
            "_txn:atr-846-#1292",
            "_txn:atr-847-#1286",
            "_txn:atr-848-#1d9",
            "_txn:atr-849-#2e9",
            "_txn:atr-850-#241",
            "_txn:atr-851-#151",
            "_txn:atr-852-#529",
            "_txn:atr-853-#639",
            "_txn:atr-854-#959",
            "_txn:atr-855-#12ce",
            "_txn:atr-856-#bb3",
            "_txn:atr-857-#8c7",
            "_txn:atr-858-#bbe",
            "_txn:atr-859-#b8",
            "_txn:atr-860-#193",
            "_txn:atr-861-#283",
            "_txn:atr-862-#235",
            "_txn:atr-863-#14",
            "_txn:atr-864-#1009",
            "_txn:atr-865-#829",
            "_txn:atr-866-#ae9",
            "_txn:atr-867-#9f",
            "_txn:atr-868-#b2a",
            "_txn:atr-869-#83e",
            "_txn:atr-870-#af8",
            "_txn:atr-871-#d58",
            "_txn:atr-872-#b86",
            "_txn:atr-873-#892",
            "_txn:atr-874-#23",
            "_txn:atr-875-#200",
            "_txn:atr-876-#678",
            "_txn:atr-877-#3d8",
            "_txn:atr-878-#1893",
            "_txn:atr-879-#1887",
            "_txn:atr-880-#b76",
            "_txn:atr-881-#82c",
            "_txn:atr-882-#21",
            "_txn:atr-883-#b8a",
            "_txn:atr-884-#1c8",
            "_txn:atr-885-#2b8",
            "_txn:atr-886-#8a",
            "_txn:atr-887-#1bc1",
            "_txn:atr-888-#291",
            "_txn:atr-889-#181",
            "_txn:atr-890-#629",
            "_txn:atr-891-#9d",
            "_txn:atr-892-#141",
            "_txn:atr-893-#251",
            "_txn:atr-894-#b9f",
            "_txn:atr-895-#34",
            "_txn:atr-896-#10d",
            "_txn:atr-897-#21d",
            "_txn:atr-898-#102",
            "_txn:atr-899-#212",
            "_txn:atr-900-#32",
            "_txn:atr-901-#6a8",
            "_txn:atr-902-#59c8",
            "_txn:atr-903-#11c9",
            "_txn:atr-904-#b02",
            "_txn:atr-905-#816",
            "_txn:atr-906-#8bc",
            "_txn:atr-907-#c24",
            "_txn:atr-908-#24",
            "_txn:atr-909-#9a9",
            "_txn:atr-910-#891",
            "_txn:atr-911-#b85",
            "_txn:atr-912-#59",
            "_txn:atr-913-#b0b",
            "_txn:atr-914-#28d",
            "_txn:atr-915-#19d",
            "_txn:atr-916-#12b0",
            "_txn:atr-917-#12c4",
            "_txn:atr-918-#298",
            "_txn:atr-919-#188",
            "_txn:atr-920-#be9",
            "_txn:atr-921-#c0",
            "_txn:atr-922-#839",
            "_txn:atr-923-#48a9",
            "_txn:atr-924-#117",
            "_txn:atr-925-#13",
            "_txn:atr-926-#2cb",
            "_txn:atr-927-#1bb",
            "_txn:atr-928-#168",
            "_txn:atr-929-#278",
            "_txn:atr-930-#2ba",
            "_txn:atr-931-#0",
            "_txn:atr-932-#328",
            "_txn:atr-933-#6a8",
            "_txn:atr-934-#1289",
            "_txn:atr-935-#3828",
            "_txn:atr-936-#9",
            "_txn:atr-937-#86",
            "_txn:atr-938-#b0d",
            "_txn:atr-939-#851",
            "_txn:atr-940-#88d",
            "_txn:atr-941-#ba3",
            "_txn:atr-942-#b2f",
            "_txn:atr-943-#83b",
            "_txn:atr-944-#291",
            "_txn:atr-945-#181",
            "_txn:atr-946-#9d",
            "_txn:atr-947-#227",
            "_txn:atr-948-#1349",
            "_txn:atr-949-#3878",
            "_txn:atr-950-#106",
            "_txn:atr-951-#216",
            "_txn:atr-952-#558",
            "_txn:atr-953-#648",
            "_txn:atr-954-#928",
            "_txn:atr-955-#21",
            "_txn:atr-956-#8ba",
            "_txn:atr-957-#bce",
            "_txn:atr-958-#8b7",
            "_txn:atr-959-#bc3",
            "_txn:atr-960-#28c",
            "_txn:atr-961-#19c",
            "_txn:atr-962-#c5",
            "_txn:atr-963-#23e",
            "_txn:atr-964-#9a8",
            "_txn:atr-965-#1bc8",
            "_txn:atr-966-#16",
            "_txn:atr-967-#fd8",
            "_txn:atr-968-#b25",
            "_txn:atr-969-#831",
            "_txn:atr-970-#8b9",
            "_txn:atr-971-#4b",
            "_txn:atr-972-#8c3",
            "_txn:atr-973-#bb7",
            "_txn:atr-974-#22b",
            "_txn:atr-975-#b0",
            "_txn:atr-976-#2bf",
            "_txn:atr-977-#1cf",
            "_txn:atr-978-#4a",
            "_txn:atr-979-#1c0",
            "_txn:atr-980-#801",
            "_txn:atr-981-#b15",
            "_txn:atr-982-#bf1",
            "_txn:atr-983-#b2",
            "_txn:atr-984-#2939",
            "_txn:atr-985-#1b08",
            "_txn:atr-986-#219",
            "_txn:atr-987-#109",
            "_txn:atr-988-#1b0",
            "_txn:atr-989-#2c0",
            "_txn:atr-990-#14",
            "_txn:atr-991-#138",
            "_txn:atr-992-#210",
            "_txn:atr-993-#100",
            "_txn:atr-994-#9f",
            "_txn:atr-995-#b96",
            "_txn:atr-996-#898",
            "_txn:atr-997-#1f08",
            "_txn:atr-998-#aa9",
            "_txn:atr-999-#d29",
            "_txn:atr-1000-#858",
            "_txn:atr-1001-#1249",
            "_txn:atr-1002-#bc8",
            "_txn:atr-1003-#ab8",
            "_txn:atr-1004-#29a",
            "_txn:atr-1005-#18a",
            "_txn:atr-1006-#59",
            "_txn:atr-1007-#266",
            "_txn:atr-1008-#2",
            "_txn:atr-1009-#141",
            "_txn:atr-1010-#59",
            "_txn:atr-1011-#2d9",
            "_txn:atr-1012-#181",
            "_txn:atr-1013-#5",
            "_txn:atr-1014-#b17",
            "_txn:atr-1015-#803",
            "_txn:atr-1016-#f49",
            "_txn:atr-1017-#e59",
            "_txn:atr-1018-#878",
            "_txn:atr-1019-#1006",
            "_txn:atr-1020-#249",
            "_txn:atr-1021-#159",
            "_txn:atr-1022-#cb",
            "_txn:atr-1023-#10c2"
        });
        public static int NumAtrs => AllAtrIds.Count;

        public static string GetAtrId(string key)
        {
            return GetAtrId(GetVBucketId(key));
        }

        public static string GetAtrId(int vBucketId)
        {
            return AllAtrIds[vBucketId];
        }

        public static int GetVBucketId(string key) => VBucketMapper.GetVBucketId(key, VBucketMask);

        public static IEnumerable<string> Nth(int startIndex, int n)
        {
            for (int i = startIndex; i < AllAtrIds.Count; i += n)
            {
                yield return AllAtrIds[i];
            }
        }
    }
}


/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2024 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/








