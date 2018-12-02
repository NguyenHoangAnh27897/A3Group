$(document).ready(function() {
    
    "use strict";
    
    // Setup html5 version
    $("#uploader").pluploadQueue({
        // General settings
        runtimes : 'html5,flash,silverlight,html4',
        url : "/aboutmaster/upload",
         
        chunk_size : '1mb',
        rename : true,
        dragdrop: true,
         
        filters : {
            // Maximum file size
            max_file_size : '10mb',
            // Specify what files to browse for
            mime_types: [
                {title : "Image files", extensions : "jpg,gif,png"},
                {title : "Zip files", extensions : "zip"}
            ]
        },
 
        // Resize images on clientside if we can
        resize: {
            width : 705,
            height : 396,
            quality : 90,
            crop: true // crop to exact dimensions
        },
 
 
        // Flash settings
        flash_swf_url : '/admin1/assets/plugins/plupload/js/Moxie.swf',
     
        // Silverlight settings
        silverlight_xap_url : '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#imagemember").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/membermaster/upload",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#imageproject").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/projectmaster/upload",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#imageicon").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/partnermaster/upload",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#imageblog").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/blogmaster/upload",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#imagecustomer").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/customermaster/upload",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#difference1").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/differencemaster/upload1",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#difference2").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/differencemaster/upload2",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#difference3").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/differencemaster/upload3",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });

    $("#difference4").pluploadQueue({
        // General settings
        runtimes: 'html5,flash,silverlight,html4',
        url: "/differencemaster/upload4",

        chunk_size: '1mb',
        rename: true,
        dragdrop: true,

        filters: {
            // Maximum file size
            max_file_size: '10mb',
            // Specify what files to browse for
            mime_types: [
                { title: "Image files", extensions: "jpg,gif,png" },
                { title: "Zip files", extensions: "zip" }
            ]
        },

        // Resize images on clientside if we can
        resize: {
            width: 705,
            height: 396,
            quality: 90,
            crop: true // crop to exact dimensions
        },


        // Flash settings
        flash_swf_url: '/admin1/assets/plugins/plupload/js/Moxie.swf',

        // Silverlight settings
        silverlight_xap_url: '/admin1/assets/plugins/plupload/js/Moxie.xap'
    });
});