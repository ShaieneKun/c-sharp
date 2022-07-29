FROM mono
WORKDIR /app
ADD ./projects /app
RUN apt-get update && apt-get install -y mono-xsp4