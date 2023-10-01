# 基础镜像
FROM node:16.17.1

# 设置工作目录
WORKDIR /app

# 复制包依赖定义
COPY package*.json ./

# 安装依赖
RUN npm install

# 复制所有文件
COPY . .

# 暴露端口 
EXPOSE 8080

# 运行命令
CMD ["npm", "run", "serve"]