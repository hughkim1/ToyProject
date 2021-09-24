// Webpack uses this to work with directories
const path = require('path');
let HtmlWebpackPlugin = require('html-webpack-plugin');
let VueLoaderPlugin = require('vue-loader/lib/plugin');
// This is the main configuration object.
// Here, you write different options and tell Webpack what to do
module.exports = {

    // Path to your entry point. From this file Webpack will begin its work
    entry: './src/main.js',

    // Path and filename of your result bundle.
    // Webpack will bundle all JavaScript into this file
    output: {
        path: path.join(__dirname, 'build/js'),
        publicPath: '/build/js', // instead of publicPath: '/build/' 
        filename: '[name].js'
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader",
                    options: {
                        presets: ['@babel/preset-env']
                    }
                },
            },
            {
                test: /\.(sa|sc|c)ss$/,
                use: [
                    {
                        // This loader resolves url() and @imports inside CSS
                        loader: "css-loader",
                    }
                ]
            },
            {
                test: /\.vue$/,
                loader: "vue-loader",
            },
        ],
    },
    plugins: [
        new VueLoaderPlugin(),
        new HtmlWebpackPlugin()
    ],
    resolve: {
        alias: {
            vue$: "vue/dist/vue.runtime.esm.js",
            "@": path.resolve(__dirname, "./src")
        },
        extensions: ["*", ".js", ".vue", ".json"],
    },

    // Default mode for Webpack is production.
    // Depending on mode Webpack will apply different things
    // on the final bundle. For now, we don't need production's JavaScript 
    // minifying and other things, so let's set mode to development
    
    devServer: {
        contentBase: path.join(__dirname, 'dist'),
        historyApiFallback: true,
        inline: true,
        port: 8080
    },
};