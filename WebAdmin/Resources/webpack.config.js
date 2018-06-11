
const htmlPlugin = require('html-webpack-plugin');// 打包html
const path = require('path');
var RawBundlerPlugin = require('webpack-raw-bundler'); //这个似乎没有解析依赖链,只是把src的转到dist,没有解析css中的url()图片
const MiniCssExtractPlugin = require("mini-css-extract-plugin");




module.exports = {
    entry: {
        entry: './src/entry.js',

    },
    output: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'bundle.js',
        
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    "css-loader"

                ]
            }, {
                test: /\.(png|jpg|gif)$/,
                use: [{
                    loader: 'url-loader',
                    options: {
                        limit: 50000,
                        outputPath: 'images'
                    }
                }]
            }, {
                test: /\.(htm|html)$/i,
                use: ['html-withimg-loader']
            }
        ]

    },
    plugins: [
        new htmlPlugin({
            minify: { removeAttributeQuotes: true }, // 压缩
            hash: true, //防止缓存
            template: './src/index.html' //要打包的文件路径
        }),

        new MiniCssExtractPlugin({
            filename: 'css/avtar.css',
            chunkFilename: ""
        }),

        new RawBundlerPlugin({
            readEncoding: "utf-8",
            includeFilePathComments: true,
            allowDuplicatesInBundle: false,
            printProgress: false,
            fileEnding: ";\n\n",
            commentTags: { Start: "/* ", End: " */" },
            bundles: [
                "styles.css",

                "plugins.js"
            ],

            "styles.css": [
                'src/static/h-ui/css/H-ui.min.css',
                'src/lib/Hui-iconfont/1.0.8/iconfont.min.css'
            ],
            "plugins.js": [
                'src/lib/jquery/1.9.1/jquery.min.js',
                'src/lib/jquery-ui/1.9.1/jquery-ui.min.js',
                'src/static/h-ui/js/H-ui.js',
                'src/lib/jquery.SuperSlide/2.1.1/jquery.SuperSlide.min.js',
                'src/lib/jquery.validation/1.14.0/jquery.validate.min.js',
                'src/lib/jquery.validation/1.14.0/validate-methods.js',
                'src/lib/jquery.validation/1.14.0/messages_zh.min.js'

            ]
        })



    ],
    devServer: {
        //绝对路径
        contentBase: path.resolve(__dirname, 'dist'),
        //服务器ip地址
        host: 'localhost',
        //是否开启压缩
        compress: true,
        //配置端口号
        port: 1717
    }
}