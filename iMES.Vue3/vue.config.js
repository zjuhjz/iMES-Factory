// const webpack = require("webpack");

module.exports = {
  productionSourceMap: false,
  lintOnSave: false,
  publicPath: './',
  devServer: {
    port: 9990,
    hot: true,
    host:'0.0.0.0',
    overlay: {
      warning: false,
      errors: false
    }
  },
  css: {
    //查看CSS属于哪个css文件
    sourceMap: true
  },
  configureWebpack: {
    module: {
      rules: [
        {
          test: /\.mjs$/,
          include: /node_modules/,
          type: "javascript/auto"
        },
      ]
    }
  },
  //https://cli.vuejs.org/zh/guide/html-and-static-assets.html#html
  chainWebpack: (config) => {
    // 移除 prefetch 插件
    config.plugins.delete('prefetch');
    //自下定义title
    config.plugin('html').tap((args) => {
      args[0].title = 'iMES-您的新一代工厂管家【开源版】 ';
      return args;
    });

    // 或者
    // 修改它的选项：
    // config.plugin('prefetch').tap(options => {
    //   options[0].fileBlacklist = options[0].fileBlacklist || []
    //   options[0].fileBlacklist.push(/myasyncRoute(.)+?\.js$/)
    //   return options
    // })
  }
  // configureWebpack: {
  //     plugins: [
  //         new webpack.optimize.MinChunkSizePlugin({
  //             minChunkSize: 100000 // 通过合并小于 minChunkSize 大小的 chunk，将 chunk 体积保持在指定大小限制以上
  //         })
  //     ]
  // }
};
