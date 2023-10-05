// vite.config.js
export default {
    // 项目根目录
    root: process.cwd(),

    // 开发服务器配置
    server: {
        host: 'localhost',
        port: 9990,
        open: true
    },

    // 构建配置
    build: {
        outDir: 'dist',
        assetsDir: 'assets'
    },

    // 插件
    plugins: [

    ],

    // 解析选项
    resolve: {
        alias: [
            { find: '@', replacement: '/src' }
        ]
    },

    // CSS相关配置
    css: {
        preprocessorOptions: {
            scss: {
                additionalData: `@import "./src/styles/variables";`
            }
        }
    }
}