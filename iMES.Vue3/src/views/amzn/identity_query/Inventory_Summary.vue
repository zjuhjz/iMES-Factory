<!--
*Author：COCO
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/amzn/identity_query/inventory_summary.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
import extend from "@/extension/amzn/identity_query/inventory_summary.js";
import {ref, defineComponent} from "vue";

export default defineComponent({
    setup() {
        const table = ref({
            key: 'sellerSku',
            footer: "Foots",
            cnName: '亚马逊ID查询',
            name: 'Inventory_Summary',
            url: "/Inventory_Summary/",
            sortName: "sellerSku"
        });
        const editFormFields = ref({"sellerSku": "", "productName": "", "asin": "", "fnSku": "", "branchId": ""});
        const editFormOptions = ref([[{
            "title": "sellerSku",
            "required": true,
            "field": "sellerSku",
            "disabled": true,
            "type": "text"
        },
            {"title": "productName", "field": "productName", "type": "text"}],
            [{"title": "asin", "field": "asin", "type": "text"},
                {"title": "fnSku", "field": "fnSku", "type": "text"},
                {"title": "branchId", "field": "branchId", "type": "text"}]]);
        const searchFormFields = ref({"asin": "", "sellerSku": "", "fnSku": "", "productName": "", "branchId": ""});
        const searchFormOptions = ref([[{
            "title": "sellerSku",
            "field": "sellerSku",
            "type": "like"
        }, {"title": "productName", "field": "productName", "type": "like"}], [{
            "title": "asin",
            "field": "asin",
            "type": "like"
        }, {"title": "fnSku", "field": "fnSku", "type": "like"}, {
            "title": "branchId",
            "field": "branchId",
            "type": "like"
        }]]);
        const columns = ref([{field: 'asin', title: 'asin', type: 'string', width: 110, align: 'left', sort: true},
            {
                field: 'sellerSku',
                title: 'sellerSku',
                type: 'string',
                width: 110,
                hidden: false,
                readonly: true,
                require: true,
                align: 'left'
            },
            {field: 'fnSku', title: 'fnSku', type: 'string', width: 110, align: 'left'},
            {field: 'productName', title: 'productName', type: 'string', width: 220, align: 'left'},
            {field: 'branchId', title: 'branchId', type: 'int', width: 80, align: 'left'}]);
        const detail = ref({
            cnName: "#detailCnName",
            table: "#detailTable",
            columns: [],
            sortName: "",
            key: ""
        });
        return {
            table,
            extend,
            editFormFields,
            editFormOptions,
            searchFormFields,
            searchFormOptions,
            columns,
            detail,
        };
    },
});
</script>
